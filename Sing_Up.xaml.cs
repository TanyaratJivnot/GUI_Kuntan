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
    /// Interaction logic for Sing_Up.xaml
    /// </summary>
    public partial class Sing_Up : Window
    {
        public Sing_Up()
        {
            InitializeComponent();
          
        }
        private void submit_Click(object sender, RoutedEventArgs e)
        {
            //ประกาศคลาส SingDB_CustomerToCheck เพื่อทำการเช็คข้อมูลที่ผู้ใช้ใส่เข้ามาว่าถูกต้องครบถ้วนหรือไม่
            SingDB_CustomerToCheck s = new SingDB_CustomerToCheck(NameBox.Text, MailBox.Text, PasswordBox.Password, TelBox.Text, Addess.Text);
            List<string> txt = new List<string>();//สร้างริสขึ้นมาเพื่อเก็บข้อมูลลงในtextfile
            if (s.CheckAllOutput == false)
            {
                MessageBox.Show("กรุณากรอกข็อมูลให้ครบถ้วน");
            }
            else if (s.CheckNameOutput == false)
            {
                MessageBox.Show("ชื่อควรมีข้อความไม่เกิน 20 ตัวอักษร");
            }
            else if (s.CheckEmailOutput == false)
            {
                MessageBox.Show("Email ควรมีข้อความไม่เกิน 30 ตัวอักษร");
            }
            else if (s.CheckPasswordOutput == false)
            {
                MessageBox.Show("Password ต้องมีตัวอักษรตั้งแต่ 1 ถึง 13 ตัว");
            }
            else if (s.CheckTelOutput == false)
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรจำนวน 10 หลัก");
            }
            else if (s.CheckAddessOutput == false)
            {
                MessageBox.Show("โปรดกรอกข้อมูลที่อยู่ให้ครบถ้วน");
            }
            else if (s.CheckNameToDuplicateOutput == false)
            {
                MessageBox.Show("ชื่อนี้ถูกใช้งานไปแล้ว");
            }
            else//ถ้าผู้ใช้กรอกข้อมูลครบถ้วน จะทำการส่งค่าที่ผู้ใช้ไปยังฐานข้อมูลเพื่อบันทึกเก็บลงฐานข้อมูล
            {
                SingUpCustomerDB singDB_Customer = new SingUpCustomerDB(NameBox.Text, MailBox.Text, PasswordBox.Password, TelBox.Text, Addess.Text);
                MessageBox.Show("สมัครสมาชิกเเรียบร้อย");
                Home home = new Home();//เมื่อบันทึกเสร็จให้ไปยังหน้าhomeว่าทำการสมัครสมาชิกเรียบร้อยเเล้ว
                home.PickPasswordForCheck(PasswordBox.Password);
                //เปิดคลาสสำหรับ เขียนข้อมูลลงในTextfile และใส่ที่อยู่ไฟล์ที่จะบันทึกนั้นลงไป
                CusCoppy cusCoppy = new CusCoppy("C:\\Users\\Admin\\Desktop\\Kun-20210420T073905Z-001\\Kun-20210420T073905Z-001\\Kun\\CatShop\\CusT.txt");
                txt = new List<string>();
                txt.Add(PasswordBox.Password);//เขียน passwordที่ผู้ใช้ได้ทำการกรอdไว้ในtextfile เพื่อนำไปเช็คกับsqliteในการดึงข้อมูลลูกค้าที่สมัครไว้หน้าhome
                cusCoppy.WriteFile(txt);//เรียกใช้เมธอดในการเขียนข้อมูลลงในtextfile
            }

        }

        private void CloseSing_Click(object sender, RoutedEventArgs e)//ปิดหน้าต่าง
        {
            this.Close();
        }
    }
}
