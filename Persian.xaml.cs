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
    /// Interaction logic for Persian.xaml
    /// </summary>
    public partial class Persian : Window
    {
        public Persian()
        {
            InitializeComponent();
        }

        private void HomePersian_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void ClosePersian_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Catpersian_Click(object sender, RoutedEventArgs e)
        {
            int id = 26;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();

        }

        private void Catpersian1_Click(object sender, RoutedEventArgs e)
        {
            int id = 27;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();

        }

        private void Catpersian2_Click(object sender, RoutedEventArgs e)
        {
            int id = 28;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();

        }

        private void Catpersian3_Click(object sender, RoutedEventArgs e)
        {
            int id = 29;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();

        }

        private void Catpersian4_Click(object sender, RoutedEventArgs e)
        {
            int id = 30;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();

        }
    }
}
