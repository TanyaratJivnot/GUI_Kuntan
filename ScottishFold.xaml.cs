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
    /// Interaction logic for ScottishFold.xaml
    /// </summary>
    public partial class ScottishFold : Window
    {
        public ScottishFold()
        {
            InitializeComponent();
        }

        private void HomeScot_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void CloseScot_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SC1_Click(object sender, RoutedEventArgs e)
        {
            int id = 31;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void SC2_Click(object sender, RoutedEventArgs e)
        {
            int id = 32;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();

        }

        private void SC3_Click(object sender, RoutedEventArgs e)
        {
            int id = 33;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void SC4_Click(object sender, RoutedEventArgs e)
        {
            int id = 34;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void SC5_Click(object sender, RoutedEventArgs e)
        {
            int id = 35;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }
    }
}
