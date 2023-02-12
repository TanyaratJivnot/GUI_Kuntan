using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CatShop
{
    /// <summary>
    /// Interaction logic for HistoryFoCat.xaml
    /// </summary>
    public partial class HistoryFoCat : Window
    {
        private List<string> orders = new List<string>();
        Tablecat tablecat = new Tablecat(); 
        private string[] cat;//สำหรับเก็บข้อมูลที่อ่าน
        private string Picturefile = "CatAll/";//ชื่อไฟล์รุป
        private int id;
        private string Picture;
        private string species;
        private string ss;
        private string eyes;
        private string price;
        //เรียกใช้คลาส CusCoppy ในการเก็บข้อมูลแมวที่ลูกค้าเลือกลงในtextfile
        CusCoppy CusCoppy = new CusCoppy("C:\\Users\\Admin\\Desktop\\Kun-20210420T073905Z-001\\Kun-20210420T073905Z-001\\Kun\\CatShop\\bill.txt");
        List<string> txt = new List<string>();
        
        public HistoryFoCat()
        {
            InitializeComponent();
            
        }
        public HistoryFoCat(int id)
        {

            PicNumForCheck(id);//รับค่าเพื่อนำมาเช็คในSqliteเพื่อดึงข้อมูลเเมว
            

        }
        public void PicNumForCheck(int id)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=CatShop.db"))//เปิดฐานข้อมูล
            {
                cat = new string[7];//ประกาสอาเรย์เพื่อเก็บข้อมูลเเมว
               
                db.Open();//เปิดตาราง
                SqliteCommand commandName = new SqliteCommand("SELECT ID,Picture,Species,Sex,Eyes,Price FROM CatDB", db);//คำสั่งsqlie

                SqliteDataReader sqliteDataReader = commandName.ExecuteReader();

                while (sqliteDataReader.Read())//อ่านที่ละบรรทัด
                {
                   
                    cat[0] = sqliteDataReader.GetString(0);//ตำแหน่งไอดี
                    int i = Convert.ToInt32(cat[0]);//แปลงให้เป็นตัวเลข
                    if (i == id)//เข้าสู่เงื่อนไขในการเช็คถ้าตัวเลขที่รับมาตรงกับตัวเลขในฐานข้อมูล
                    {
                        //ให้ข้อมูลเเต่ละตัวเก็บลงในตัวเเปรต่างๆ
                        cat[1] = sqliteDataReader.GetString(1);
                        cat[2] = sqliteDataReader.GetString(2);
                        cat[3] = sqliteDataReader.GetString(3);
                        cat[4] = sqliteDataReader.GetString(4);
                        cat[5] = sqliteDataReader.GetString(5);
                        //ให้ข้อมูลเเต่ละตัวเก็บลงในตัวเเปรต่างๆ
                        string imm = cat[1];
                        string spp = cat[2];
                        string ss = cat[3];
                        string es = cat[4];
                        string ppp = cat[5];
                        BitmapImage bitmap = new BitmapImage();//การแปลงให้คอมเข้าใจแปลงเอารูปแปลงเป็นภาษาให้คอมเข้าใจ
                        bitmap.BeginInit();
                        bitmap.UriSource = new Uri(imm, UriKind.Relative);//เอาชื่อโลของรุปมาแปลง
                        bitmap.EndInit();
                        image.Source = bitmap;//ให้ใส่.ซอสได้
                        //นำข้อมูลมาโชว์ลงในกล่องข้อความ
                        Species.Text = spp;
                        Sex.Text = ss;
                        Eyes.Text = es;
                        Price.Text = ppp;
                        //นำข้อมูลมาโชว์ลงในกล่องข้อความ
                        break;
                    }
                    

                }
                
            }
        }
       
    private void HomeHistory_Click(object sender, RoutedEventArgs e)
    {
        Home home = new Home();
        home.Show();
    }

    private void CloseHistory_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
           
            species = Species.Text;
            eyes = Eyes.Text;
            ss = Sex.Text;
            price = Price.Text;
            //เขียนข้อมูลแทวที่ดึงมาลงในtextfileเพื่อไว้แสดงโชว์บิลในการซื้อแมว
            DetailCat detailCat = new DetailCat(species,eyes,ss,price);
            string txtCat = detailCat.AllDetail();
            txt.Add(txtCat);
            CusCoppy.WriteFile(txt);
            //เปิดคลาสBuy_a_Catเพื่อทำการส่งค่าข้อมูลแมวที่ลูกค้าเลือกไปหน้าการสั่งซื้อ
            Buy_a_Cat buy_A_Cat = new Buy_a_Cat();
            buy_A_Cat.speciesCat.Text = Species.Text;
            buy_A_Cat.eyescat.Text = Eyes.Text;
            buy_A_Cat.sexCat.Text = Sex.Text;
            buy_A_Cat.priceCat.Text = Price.Text;
            //เปิดคลาสBuy_a_Catเพื่อทำการส่งค่าข้อมูลแมวที่ลูกค้าเลือกไปหน้าการสั่งซื้อ
            buy_A_Cat.Show();
            this.Close();//ปิดการทำงานเมื่อจบ
    }

    
}
}

    

