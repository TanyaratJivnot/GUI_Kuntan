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
    /// Interaction logic for ManyMore.xaml
    /// </summary>
    public partial class ManyMore : Window
    {
        public ManyMore()
        {
            InitializeComponent();
        }

        private void HomeManyMore_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void CloseManyMore_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void MM1_Click(object sender, RoutedEventArgs e)
        {
            int id = 21;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void MM2_Click(object sender, RoutedEventArgs e)
        {
            int id = 22;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void MM3_Click(object sender, RoutedEventArgs e)
        {
            int id = 23;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void MM4_Click(object sender, RoutedEventArgs e)
        {
            int id = 24;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }

        private void MM5_Click(object sender, RoutedEventArgs e)
        {
            int id = 25;
            HistoryFoCat historyFoCat = new HistoryFoCat();
            historyFoCat.PicNumForCheck(id);
            historyFoCat.Show();
            this.Close();
        }
    }
}
