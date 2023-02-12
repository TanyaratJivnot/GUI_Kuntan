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
    /// Interaction logic for AmericanShorthair.xaml
    /// </summary>
    public partial class AmericanShorthair : Window
    {
        public AmericanShorthair()
        {
            InitializeComponent();
        }

        private void HomeAmerican_Click(object sender, RoutedEventArgs e)//ปุ่มสำหรับคลิ๊กไปหน้าหลักHome
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
        //หน้านี้มีการทำงาน โดยให้เลือกหน้าแมว และข้อมูลจะถูกส่งไปยีงหน้าซื้อเเมว
        private void CloseAmerican1_Click(object sender, RoutedEventArgs e)//ปุ่มปิด
        {
            this.Close();
        }

        private void A1_Click(object sender, RoutedEventArgs e)//ปุ่มสำหรับเลือกเเมวตัวนี้เพื่อไปหน้ากดซื้อ
        {
            int id = 11;//เก็บค่าตำแหน่งในsqliteเพื่อทำการเช็คข้อมูลและดึงข้อมูลมา
            HistoryFoCat historyFoCat = new HistoryFoCat();//เปิดใช้งานเพื่อเรียกใช้เมธอดในการส่งค่าตัวแปร
            historyFoCat.PicNumForCheck(id);//ส่งค่า int id ไปยังเมธอด PicNumForCheck(id) เพื่อทำการดึงข้อมูลเเมว
            historyFoCat.Show();//คำสั่งไปยังหน้า HistoryFoCat ซื้อแมว
            this.Close();//พอจบการทำงานให้ปิดหน้านี้
        }

        private void A2_Click(object sender, RoutedEventArgs e)//ปุ่มสำหรับเลือกเเมวตัวนี้เพื่อไปหน้ากดซื้อ
        {
            int id = 12;//เก็บค่าตำแหน่งในsqliteเพื่อทำการเช็คข้อมูลและดึงข้อมูลมา
            HistoryFoCat historyFoCat = new HistoryFoCat();//เปิดใช้งานเพื่อเรียกใช้เมธอดในการส่งค่าตัวแปร
            historyFoCat.PicNumForCheck(id);//ส่งค่า int id ไปยังเมธอด PicNumForCheck(id) เพื่อทำการดึงข้อมูลเเมว
            historyFoCat.Show();//คำสั่งไปยังหน้า HistoryFoCat ซื้อแมว
            this.Close();//พอจบการทำงานให้ปิดหน้านี้
        }

        private void A3_Click(object sender, RoutedEventArgs e)//ปุ่มสำหรับเลือกเเมวตัวนี้เพื่อไปหน้ากดซื้อ
        {
            int id = 13;//เก็บค่าตำแหน่งในsqliteเพื่อทำการเช็คข้อมูลและดึงข้อมูลมา
            HistoryFoCat historyFoCat = new HistoryFoCat();//เปิดใช้งานเพื่อเรียกใช้เมธอดในการส่งค่าตัวแปร
            historyFoCat.PicNumForCheck(id);//ส่งค่า int id ไปยังเมธอด PicNumForCheck(id) เพื่อทำการดึงข้อมูลเเมว
            historyFoCat.Show();//คำสั่งไปยังหน้า HistoryFoCat ซื้อแมว
            this.Close();//พอจบการทำงานให้ปิดหน้านี้
        }

        private void A4_Click(object sender, RoutedEventArgs e)//ปุ่มสำหรับเลือกเเมวตัวนี้เพื่อไปหน้ากดซื้อ
        {
            int id = 14;//เก็บค่าตำแหน่งในsqliteเพื่อทำการเช็คข้อมูลและดึงข้อมูลมา
            HistoryFoCat historyFoCat = new HistoryFoCat();//เปิดใช้งานเพื่อเรียกใช้เมธอดในการส่งค่าตัวแปร
            historyFoCat.PicNumForCheck(id);//ส่งค่า int id ไปยังเมธอด PicNumForCheck(id) เพื่อทำการดึงข้อมูลเเมว
            historyFoCat.Show();//คำสั่งไปยังหน้า HistoryFoCat ซื้อแมว
            this.Close();//พอจบการทำงานให้ปิดหน้านี้
        }

        private void A5_Click(object sender, RoutedEventArgs e)//ปุ่มสำหรับเลือกเเมวตัวนี้เพื่อไปหน้ากดซื้อ
        {
            int id = 15;//เก็บค่าตำแหน่งในsqliteเพื่อทำการเช็คข้อมูลและดึงข้อมูลมา
            HistoryFoCat historyFoCat = new HistoryFoCat();//เปิดใช้งานเพื่อเรียกใช้เมธอดในการส่งค่าตัวแปร
            historyFoCat.PicNumForCheck(id);//ส่งค่า int id ไปยังเมธอด PicNumForCheck(id) เพื่อทำการดึงข้อมูลเเมว
            historyFoCat.Show();//คำสั่งไปยังหน้า HistoryFoCat ซื้อแมว
            this.Close();//พอจบการทำงานให้ปิดหน้านี้
        }
    }
}
