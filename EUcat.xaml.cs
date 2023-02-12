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
    /// Interaction logic for EUcat.xaml
    /// </summary>
    public partial class EUcat : Window
    {
        public EUcat()
        {
            InitializeComponent();
        }

        private void ClosEU_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BackEU_Click(object sender, RoutedEventArgs e)//เชื่อมไปหน้าโฮม
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Scottish_Fold_Click(object sender, RoutedEventArgs e)//เชื่อมไปหน้า ScottishFold
        {
            ScottishFold scottishFold = new ScottishFold();
            scottishFold.Show();
            this.Close();
        }

        private void American_Shorthair_Click(object sender, RoutedEventArgs e)//เชื่อมไปหน้า  AmericanShorthair
        {
            AmericanShorthair americanShorthair = new AmericanShorthair();
            americanShorthair.Show();
            this.Close();
        }

        private void Persian_Click(object sender, RoutedEventArgs e)//เชื่อมไปหน้า  Persian
        {
            Persian persian = new Persian();
            persian.Show();
            this.Close();
        }

        private void Maine_Coon_Click(object sender, RoutedEventArgs e)//เชื่อมไปหน้า  MaineCoon
        {
            MaineCoon maineCoon = new MaineCoon();
            maineCoon.Show();
            this.Close();
        }

        private void Sphinx_Click(object sender, RoutedEventArgs e)//เชื่อมไปหน้า  Sphinx
        {
            Sphinx sphinx = new Sphinx();
            sphinx.Show();
            this.Close();
        }
    }
}
