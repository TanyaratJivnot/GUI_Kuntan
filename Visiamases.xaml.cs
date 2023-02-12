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
    /// Interaction logic for Visiamases.xaml
    /// </summary>
    public partial class Visiamases : Window
    {
        public Visiamases()
        {
            InitializeComponent();
        }

        private void BackVisia_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void CloseVisia_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void V1_Click(object sender, RoutedEventArgs e)
        {
            int id = 1;//กำหนดตำแหน่งให้ตรงกับในตารางSql
            HistoryFoCat historyFoCat = new HistoryFoCat();//เปิดใช้คลาสในการส่งค่าเข้าไปใช้
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();

        }

        private void V2_Click(object sender, RoutedEventArgs e)
        {
            int id = 2;//กำหนดตำแหน่งให้ตรงกับในตารางSql
            HistoryFoCat historyFoCat = new HistoryFoCat();//เปิดใช้คลาสในการส่งค่าเข้าไปใช้
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void V3_Click(object sender, RoutedEventArgs e)
        {
            int id = 3;//กำหนดตำแหน่งให้ตรงกับในตารางSql
            HistoryFoCat historyFoCat = new HistoryFoCat();//เปิดใช้คลาสในการส่งค่าเข้าไปใช้
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void V4_Click(object sender, RoutedEventArgs e)
        {
            int id = 4;//กำหนดตำแหน่งให้ตรงกับในตารางSql
            HistoryFoCat historyFoCat = new HistoryFoCat();//เปิดใช้คลาสในการส่งค่าเข้าไปใช้
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void V5_Click(object sender, RoutedEventArgs e)
        {
            int id = 5;//กำหนดตำแหน่งให้ตรงกับในตารางSql
            HistoryFoCat historyFoCat = new HistoryFoCat();//เปิดใช้คลาสในการส่งค่าเข้าไปใช้
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }
    }
}
