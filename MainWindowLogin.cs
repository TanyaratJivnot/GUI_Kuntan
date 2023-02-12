using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShop
{
    class MainWindowLogin
    {
        private string Email;
        private string Password;
        private string PickEmail;
        private string PickPassword;
        //สร้างคลาส MainWindowLoginเพื่อทำการเช็คข้อมูลสำหรับลูกค้าที่ได้สมัครเข้าใช้งานเเล้ว
        public MainWindowLogin(string email, string password)
        {
            Email=email;
            Password = password;
            PickEmailForCheck();
            PickPasswordForCheck();
        }
        public bool CheckAllkOutout
        {
            get { return CheckAll(); }
        }
        public bool EamilCheckOutput
        {
            get { return EmailCheck(); }
        }
        public bool PasswordCheckOutput
        {
            get { return PasswordCheck(); }
        }
        private bool CheckAll()//เชคว่าลูกค้าใส่ข้อมูลครบหรือไม่
        {
            bool check;
            if (Email == "" || Password == "")
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool EmailCheck()//เช็คว่าอีเมลล์ที่ลูกค้าใส่มาตรงกับฐานข้อมูลหรือไม่
        {
            bool check;
            if (Email != PickEmail)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool PasswordCheck()//เช็คว่าพาสเวริดที่ลูกค้าใส่มาตรงกับฐานข้อมูลหรือไม่
        {
            bool check;
            if (Email == PickEmail && Password != PickPassword)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private void PickEmailForCheck()//สร้างเมธอดสำหรับการเช็คข้อมูลอีเมลที่ลูกค้ากรอกเข้าไป
        {
            using (SqliteConnection db = new SqliteConnection("Filename=TableCustomer.db"))//เรียกใช้ข้อมูลsqlieที่ไว้สำหรับเก็บข้อมูลลูกค้า
            {
                db.Open();
                SqliteCommand commandEmail = new SqliteCommand();
                commandEmail.Connection = db;
                commandEmail.CommandText = "SELECT Email from Customer WHERE Name='" + Email + "'";//คำสั่งsqlieในการเรียกอีเมล

                SqliteDataReader sqliteDataReader = commandEmail.ExecuteReader();

                while (sqliteDataReader.Read())//เช็คที่ละบรรทัดว่ามีข้อมูลที่ลูกค้าสมัครไว้ไหมถ้ามีเก็บไว้ในตัวแปร PickEmail
                {
                    PickEmail = sqliteDataReader.GetString(0);
                }
                db.Close();//ปิดฐานข้อมูลเมื่อทำงานเสร็จ
            }

        }
        private void PickPasswordForCheck()//สร้างเมธอดสำหรับการเช็คข้อมูลพาสเวริดที่ลูกค้ากรอกเข้าไป
        {
            using (SqliteConnection db = new SqliteConnection("Filename=TableCustomer.db"))
            {
                db.Open();
                SqliteCommand commandEmail = new SqliteCommand();
                commandEmail.Connection = db;
                commandEmail.CommandText = "SELECT Password from Customer WHERE Name='" + Password + "'";

                SqliteDataReader sqliteDataReader = commandEmail.ExecuteReader();

                while (sqliteDataReader.Read())//เช็คที่ละบรรทัดว่ามีข้อมูลที่ลูกค้าสมัครไว้ไหมถ้ามีเก็บไว้ในตัวแปร PickPassword
                {
                    PickPassword = sqliteDataReader.GetString(0);
                }
                db.Close();//ปิดฐานข้อมูลเมื่อทำงานเสร็จ
            }

        }
    }
}
