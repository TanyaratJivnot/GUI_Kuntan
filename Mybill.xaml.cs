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
    /// Interaction logic for Mybill.xaml
    /// </summary>
    public partial class Mybill : Window
    {
        private string aa;
        private string Name;
        private string Mail;
        private string Tele;
        private string Add;
        private string[] pass = new string[6];
        //เปิดคลาสสำหรับการเขียนไฟล์เเละอ่านไฟล์เพื่อดึงข้อมูลที่ได้เขียนลงไปในtextfile
        CusCoppy file = new CusCoppy("C:\\Users\\Admin\\Desktop\\Kun-20210420T073905Z-001\\Kun-20210420T073905Z-001\\Kun\\CatShop\\bill.txt");//สำหรับที่อยู่ข้อมูลแมวที่ลูกค้าเลือกซื้อ
        CusCoppy File = new CusCoppy("C:\\Users\\Admin\\Desktop\\Kun-20210420T073905Z-001\\Kun-20210420T073905Z-001\\Kun\\CatShop\\Profile.txt");//สำหรับที่อยู่ข้อมูลผู้ใช้
        CusCoppy cus = new CusCoppy("C:\\Users\\Admin\\Desktop\\Kun-20210420T073905Z-001\\Kun-20210420T073905Z-001\\Kun\\CatShop\\pricechangcat.txt");//ที่อยู่ในการเก็บเงินทอนลูกค้า
        //สร้างlistขึ้นมาในการเก็บค่าที่อ่านเพื่อโชว์ข้อมูลที่อยู่ในTextfile
        private List<DetailCat> Details = new List<DetailCat>();
        private List<DetailCustomer> details = new List<DetailCustomer>();
        private List<DetailCat>  cats = new List<DetailCat>();
        public Mybill()
        {
            InitializeComponent();
            Details = new List<DetailCat>();//ริสสำหรับอเก็บค่าในการอ่านข้อมูลนี้แมวที่ลูกค้าซื้อ
            foreach (string i in file.ReadFile())//อ่านข้อมูล
            {

                if (i != "")//เงื่อนไขถ้าไม่เป็นช่องว่างให้ทำต่อไปนี้
                {
                    string[] data = new string[4];//สร้างอาเรย์ขึ้นมาเก็บค่าที่อ่าน
                    data = i.Split(',');//ทำการเอาลูกน้ำออกเมื่อเจอ
                    string Species = data[0];//เก็บdata[ตำแหน่งต่างๆ]ลงในตัวแปรแต่ละตัวที่เป็นค่าสตริง
                    string Eyes = data[1];
                    string sex = data[2];
                    string price = data[3];
                    DetailCat detailCat = new DetailCat(Species, Eyes, sex, price);//นำข้อมูลที่เก็บลงตัวแปรใส่ในคลาสที่ประกาศขึ้นมาเพื่อทำการรีเทรินค่าแมวที่ลูกค้าซื้อ
                    Details.Add(detailCat);//เก็บไว้ในริสที่ประกาศไว้โชว์ข้อมูล
                    //แสดงข้อความลงในกล่องข้อความ
                    SpeciesBox.Text = Species;
                    EyesBox.Text = Eyes;
                    SexBox.Text = sex;
                    priceCatBox.Text = price;
                    //แสดงข้อความลงในกล่องข้อความ
                }
            }
            details = new List<DetailCustomer>();//ริสสำหรับอเก็บค่าในการอ่านข้อมูลโปรไฟลลูกค้า
            foreach (string i in File.ReadFile())//อ่านข้อมูล
            {

                if (i != "")//เงื่อนไขถ้าไม่เป็นช่องว่างให้ทำต่อไปนี้
                {
                    string[] data = new string[4];//สร้างอาเรย์ขึ้นมาเก็บค่าที่อ่าน
                    data = i.Split(',');//ทำการเอาลูกน้ำออกเมื่อเจอ
                    string name = data[0];//เก็บdata[ตำแหน่งต่างๆ]ลงในตัวแปรแต่ละตัวที่เป็นค่าสตริง
                    string mail = data[1];
                    string tel = data[2];
                    string addess = data[3];
                    DetailCustomer detailCustomer = new DetailCustomer(name, mail, tel, addess);//นำข้อมูลที่เก็บลงตัวแปรใส่ในคลาสที่ประกาศขึ้นมาเพื่อทำการรีเทรินค่า
                    details.Add(detailCustomer);//เก็บไว้ในริสที่ประกาศไว้โชว์ข้อมูล
                    NameBox.Text = name;
                    EmailBox.Text = mail;
                    PhonBox.Text = tel;
                    AddessBox.Text = addess;
                    ;

                }
            }
            cats = new List<DetailCat>();//ริสสำหรับอเก็บค่าในการอ่านข้อมูลค่าเงินทอนลูกค้า
            foreach (string i in File.ReadFile())//อ่านข้อมูล
            {

                if (i != "")//เงื่อนไขถ้าไม่เป็นช่องว่างให้ทำต่อไปนี้
                {
                    string[] data = new string[1];//สร้างอาเรย์ขึ้นมาเก็บค่าที่อ่าน
                    data = i.Split(',');//ทำการเอาลูกน้ำออกเมื่อเจอ
                    string Chang = data[0];//เก็บdata[ตำแหน่งต่างๆ]ลงในตัวแปรแต่ละตัวที่เป็นค่าสตริง
                    DetailCat detailCat = new DetailCat(Chang);//นำข้อมูลที่เก็บลงตัวแปรใส่ในคลาสที่ประกาศขึ้นมาเพื่อทำการรีเทรินค่า
                    cats.Add(detailCat);//เก็บไว้ในริสที่ประกาศไว้โชว์ข้อมูล
                    MonneyChangBox.Text = Chang;

                }
            }


        }

        private void homeclick_Click(object sender, RoutedEventArgs e)//โค้ดเชื่อมไปยังหน้า Home 
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void close_Click(object sender, RoutedEventArgs e)//โค้ดปิดหน้าการทำงาน
        {
            this.Close();
        }
    }
}

