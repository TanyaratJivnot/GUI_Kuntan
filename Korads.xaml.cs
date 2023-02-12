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
    /// Interaction logic for Korads.xaml
    /// </summary>
    public partial class Korads : Window
    {
        public Korads()
        {
            InitializeComponent();
        }

        private void BackKorad_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void CloseKorad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
        private void K2_Click(object sender, RoutedEventArgs e)
        {
            int id = 6;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void K3_Click(object sender, RoutedEventArgs e)
        {
            int id = 7;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void K4_Click(object sender, RoutedEventArgs e)
        {
            int id = 8;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void K5_Click(object sender, RoutedEventArgs e)
        {
            int id = 9;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void K1_Click(object sender, RoutedEventArgs e)
        {
            int id = 10;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }
    }
}
