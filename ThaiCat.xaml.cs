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
    /// Interaction logic for ThaiCat.xaml
    /// </summary>
    public partial class ThaiCat : Window
    {
        //โค้ดสำหรับเลือกเเมวแต่ละสายพันธ์ของประเทศนี้
        public ThaiCat()
        {
            InitializeComponent();
        }

        private void CloseThai_Click(object sender, RoutedEventArgs e)//โค้ดปิดการทำงานหน้านี้
        {
            this.Close();
        }

        private void BackThai_Click(object sender, RoutedEventArgs e)//ปุ่มสำหรับคลิ๊กไปหน้าหลักHome
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Visiamase_Click(object sender, RoutedEventArgs e)//โค้ดการทำงานไปยังหน้าแมวสายพันธ์นี้
        {
            Visiamases vv = new Visiamases();
            vv.Show();
            this.Close();
        }

        private void Korad_Click(object sender, RoutedEventArgs e)//โค้ดการทำงานไปยังหน้าแมวสายพันธ์นี้
        {
            Korads korads = new Korads();
            korads.Show();
            this.Close();
        }

        private void Many_more__Click(object sender, RoutedEventArgs e)//โค้ดการทำงานไปยังหน้าแมวสายพันธ์นี้
        {
            ManyMore manyMore = new ManyMore();
            manyMore.Show();
            this.Close();
        }
    }
}
