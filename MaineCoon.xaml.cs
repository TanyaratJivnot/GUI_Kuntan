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
    /// Interaction logic for MaineCoon.xaml
    /// </summary>
    public partial class MaineCoon : Window
    {
        public MaineCoon()
        {
            InitializeComponent();
        }

        private void HomeMaine_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void CloseMaine_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MC2_Click(object sender, RoutedEventArgs e)
        {
            int id = 17;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void MC3_Click(object sender, RoutedEventArgs e)
        {
            int id = 18;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void MC4_Click(object sender, RoutedEventArgs e)
        {
            int id = 19;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void MC1_Click(object sender, RoutedEventArgs e)
        {
            int id = 16;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void MC5_Click(object sender, RoutedEventArgs e)
        {
            int id = 20;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }
    }
}
