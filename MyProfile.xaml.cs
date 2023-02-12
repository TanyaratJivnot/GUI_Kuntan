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
    /// Interaction logic for MyProfile.xaml
    /// </summary>
    public partial class MyProfile : Window
    {
        private string Name;
        private string Mail;
        private string Tele;
        private string Add;
        
       
        public MyProfile()
        {
            InitializeComponent();
        }
        public MyProfile(string Name, string Mail, string Tele, string Add)
        {
            //สร้างคอนสตัครเตอร์เพื่อรับค่าข้อมูลมาใส่ลงในกล่องข้อความ
            NameBox.Text = Name;
            MailBox.Text = Mail;
            phonBox.Text = Tele;
           AddessBox.Text = Add;

        }


        private void Catstor_Click(object sender, RoutedEventArgs e)//โค้ดในการเชื่อมไปยังหน้าCatStore
        {
            CatStore Cat = new CatStore();
            Cat.Show();
            this.Close();
        }
       
        private void MyBill_Click(object sender, RoutedEventArgs e)//โค้ดในการเชื่อมไปยังหน้า  Mybill
        {
           
            Mybill mybill = new Mybill();
            mybill.Show();
            this.Close();
        }

        private void Home_Click_1(object sender, RoutedEventArgs e)//โค้ดในการเชื่อมไปยังหน้า Home
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void close_Click_1(object sender, RoutedEventArgs e)//ปิดการทำงานหน้านี้
        {
            this.Close();
        }
    }
}
