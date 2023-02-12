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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CatShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseLogin_Click(object sender, RoutedEventArgs e)//โค้าการทำงานปุ่มปิดโปรแกรม
        {
            if (MessageBox.Show("Exit Program ?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void SingUp_Click(object sender, RoutedEventArgs e)//โค้ดสำหรับเชื่อมไปยังหน้า Sing_Up 
        {
            Sing_Up sing_Up = new Sing_Up();
            sing_Up.Show();
            this.Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
      {
            //เรียกใช้งานคลาสMainWindowLoginเพื่อทำการเช็คข้อมูลที่ลูกค้าใส่เข้ามา
            MainWindowLogin login = new MainWindowLogin(MailLogin.Text, PasswordLogin.Password);
            List<string> txt = new List<string>();
            if (login.CheckAllkOutout == false)
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบถ้วน");
            }
            else if (login.EamilCheckOutput == false)
            {
                MessageBox.Show("ไม่พบ User นี้ในระบบ");
            }
            else if (login.PasswordCheckOutput == false)
            {
                MessageBox.Show("รหัสผ่านไม่ถูกต้อง โปรดรองใหม่อีกครั้ง");
            }
            else if (login.EamilCheckOutput == true && login.PasswordCheckOutput == true)//ถ้าข้อมูลถูกต้อง
            {
                Home home = new Home();
                home.PickPasswordForCheck(PasswordLogin.Password);//ใส่ค่าพาสเวริดที่ลูกค้าคียืเข้าไปยังเมธอดPickMailForCheckของหน้าhomeเพื่อทำการไปเช็คละดึงข้อมูลลูกค้าออกมา
                CusCoppy cusCoppy = new CusCoppy("C:\\Users\\Admin\\Desktop\\Kun-20210420T073905Z-001\\Kun-20210420T073905Z-001\\Kun\\CatShop\\CusT.txt");
                //เปิดคลาส CusCoppyสำหรับการเขียนไฟล์พาสเวรืดลงไปในtextfile
                txt = new List<string>();
                txt.Add(PasswordLogin.Password);
                cusCoppy.WriteFile(txt);
                home.Show();
                this.Close();
            }
        }
    }
}
