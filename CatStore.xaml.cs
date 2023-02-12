using System.Windows;

namespace CatShop
{
    /// <summary>
    /// Interaction logic for CatStore.xaml
    /// </summary>
    public partial class CatStore : Window
    {
        public CatStore()
        {
            InitializeComponent();
        }

        private void CloseStore_Click(object sender, RoutedEventArgs e)//ปิดกาารทำงานหน้านี้
        {
            this.Close();
        }

        private void BackStore_Click(object sender, RoutedEventArgs e)//เชื่อต่อหน้าhome
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Account1_Click(object sender, RoutedEventArgs e)//เชื่อมต่อหน้าMyProfile
        {
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
            this.Close();
        }

        private void CatStore1_Click(object sender, RoutedEventArgs e)//เชื่อมต่อหน้า CatStore
        {
            CatStore Catstore = new CatStore();
            Catstore.Show();
            this.Close();
        }

        private void EUCat_Click(object sender, RoutedEventArgs e)//เชื่อมต่อหน้า EUcat
        {
            EUcat Eucat = new EUcat();
            Eucat.Show();
            this.Close();
        }

        private void THCat_Click(object sender, RoutedEventArgs e)//เชื่อมต่อหน้า ThaiCat
        {
            ThaiCat thaiCat = new ThaiCat();
            thaiCat.Show();
            this.Close();
        }
    }
}
