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
    /// Interaction logic for Buy_a_Cat.xaml
    /// </summary>
    public partial class Buy_a_Cat : Window
    {
        //ตัวแปรสำหรับเก็บข้อมูลแมว
        public string speciesC;
        public string eyesC;
        public string priceC;
        public string sex;
        private double money;
        private double price;
        private double total;
        private string priceChang;
        //ตัวแปรสำหรับเก็บข้อมูลแมว
        List<string> txt = new List<string>();
        CusCoppy coppy = new CusCoppy("C:\\Users\\Admin\\Desktop\\Kun-20210420T073905Z-001\\Kun-20210420T073905Z-001\\Kun\\CatShop\\pricechangcat.txt");
        //เปิดคลาส CusCoppy เพื่อเขียนเงินทอนที่ลูกค้าได้รับลงในtextfile
        public Buy_a_Cat()
        {
            InitializeComponent();
            speciesCat.Text = speciesC;
            eyescat.Text = eyesC;
            sexCat.Text = sex;
            priceCat.Text = priceC;
        }

        private void homeclick_Click(object sender, RoutedEventArgs e)//ไปยังหน้า Home
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void close_Click_1(object sender, RoutedEventArgs e)//ปิดการทำงานหน้านี้
        {
            this.Close();
        }

        private void OkBuy_Click_1(object sender, RoutedEventArgs e)
        {
            money = Convert.ToDouble(inputPrice.Text.ToString());//แปรงค่าเงินที่ลูกค้าใส่มาให้เป็นintเพื่อนำไปคำนวน
            price=Convert.ToDouble(priceCat.Text.ToString());//แปรงค่าเงินของราคาแมวให้เป็นintเพื่อนำไปคำนวน
            if (price == money)//ถ้าเงินที่ใส่==ราคาเเมว
            {
                total = money - price;//นำมาลบแล้วเก็บใน total
                changMN.Text = Convert.ToString(total.ToString());//แปรง totalในเป็นสตริงแล้วใส่ลงในกล่อง  changMN.Text
                inputPrice.Text = "";//ให้ลูกค้าใส่จำนวนเงิน
                MessageBox.Show("การสั่งซื้อสำเร็จ");
                Mybill mybill = new Mybill();//เปิดคลาสmybill
                mybill.MonneyChangBox.Text = changMN.Text;//ส่งค่าเงินทอนไปที่กล่อง MonneyChangBox.Text ของ Mybill
                mybill.Show();//เชื่องต่อหน้าMybil
                this.Close();//ปิดการทำงานของหน้านี้
            }
            else if (price < money)//ถ้าเงินที่ใส่<ราคาเเมว
            {
                total = money - price;//นำมาลบแล้วเก็บใน total
                changMN.Text = Convert.ToString(total.ToString());//แปรง totalในเป็นสตริงแล้วใส่ลงในกล่อง  changMN.Text
                inputPrice.Text = "";//ให้ลูกค้าใส่จำนวนเงิน
                Mybill mybill = new Mybill();//เปิดคลาสmybill
                MessageBox.Show("การสั่งซื้อสำเร็จ");
                mybill.MonneyChangBox.Text = changMN.Text;//ส่งค่าเงินทอนไปที่กล่อง MonneyChangBox.Text ของ Mybill
                mybill.Show();//เชื่องต่อหน้าMybil
                this.Close();//ปิดการทำงานของหน้านี้
            }
            else if (price > money)//ถ้าเงินที่ใส่>ราคาเเมว
            {
                total = money - price;//นำมาลบแล้วเก็บใน total
                changMN.Text = "0";
                inputPrice.Text = "";
                MessageBox.Show("เงินของคุณมีไม่มากพอ", "Warning", MessageBoxButton.OK, MessageBoxImage.Asterisk);//แจ้งว่าเงินลูกค้าไม่พอ
               

            }
            priceChang = changMN.Text;//เก็บข้อความจากกล่องลงในpriceChang
            DetailCat detailCat = new DetailCat(priceChang);//ส่งค่าลงใน DetailCat
            string txtC = detailCat.AllChang();//รีเทรินค่าทั้งหมด
            txt.Add(txtC);
            coppy.WriteFile(txt);//เขียนลงในtextfile
        }

    }
}


