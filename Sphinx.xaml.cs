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
    /// Interaction logic for Sphinx.xaml
    /// </summary>
    public partial class Sphinx : Window
    {
        public Sphinx()
        {
            InitializeComponent();
        }

        private void HomeSphinx_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void CloseSphinx_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SP1_Click(object sender, RoutedEventArgs e)
        {
            int id = 36;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void SP2_Click(object sender, RoutedEventArgs e)
        {
            int id = 37;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void SP3_Click(object sender, RoutedEventArgs e)
        {
            int id = 38;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void SP4_Click(object sender, RoutedEventArgs e)
        {
            int id = 39;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void SP5_Click(object sender, RoutedEventArgs e)
        {
            int id = 40;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }
    }
}
