using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShop
{
    class SingDB_CustomerToCheck
    {
        private string Name;
        private string Email;
        private string Password;
        private string Tel;
        private string Addess;
        private string ID;
        public SingDB_CustomerToCheck(string name, string mail, string password, string tel, string addess)
        {
            Name = name;
            Email = mail;
            Password = password;
            Tel = tel;
            Addess = addess;
        }
        private bool CheckAll()//เช็คว่าผู้ใช้กรอกข้อมูลครบหรือเปล่า
        {
            bool check;
            if (Name == "" || Email == "" || Password == "" || Tel == "" || Addess == "")
            {
                check = false;

            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool CheckName()//เชคจน.ชื่อไม่ให้ผู้ใช้ใส่เกิน20ตัวอักษร
        {
            bool check;
            if (Name.Length > 20)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool CheckEmail()//เชคจน.เมลล์ม่ให้ผู้ใช้ใส่เกิน30ตัวอักษร
        {
            bool check;
            if (Email.Length > 30)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool CheckPassword()//เชคจน.passwordม่ให้ผู้ใช้ใส่เกิน13ตัวอักษร
        {
            bool check;
            if (Password.Length > 13)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool CheckTel()//เชคจน.เบอร์ม่ให้ผู้ใช้ใส่เกิน10ตัวอักษร
        {
            bool check;
            if (Tel.Length > 10)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool CheckAddess()//เชคจน.ที่อยุ่ม่ให้ผู้ใช้ใส่เกิน100ตัวอักษร
        {
            bool check;
            if (Addess.Length > 100)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool CheckNameToDuplicate()
        {
            PickNameForCheck();
            bool check;
            if (Name == ID)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private void PickNameForCheck()//เมธอดสำหรับผู้ใช้ใส่ชื่อซ้ำ
        {
            using (SqliteConnection db = new SqliteConnection("Filename=TableCustomer.db"))
            {
                db.Open();//เปิดฐานข้อมูลSqlie
                SqliteCommand commandName = new SqliteCommand();
                commandName.Connection = db;
                commandName.CommandText = "SELECT Name from Customer WHERE Name='" + Name + "'";//คำสั่งsqlie ดึงชื่อไปเก็บไว้ในตัวแปรName

                SqliteDataReader sqliteDataReader = commandName.ExecuteReader();

                while (sqliteDataReader.Read())//ทำการอ่านที่ละบรรทัดในตารางข้อมูล
                {
                    ID = sqliteDataReader.GetString(0);//นำข้อมุลที่อ่านไปเก็บไว้ในตัวแปรID
                }
                db.Close();//จบการทำงานให้ปิดฐานข้อมูล
            }

        }
        //รีเทรินเมธอดเพื่อเรียกใช้สำหรับการเช็คข้อมูลลูกค้า 
        public bool CheckAllOutput
        {
            get { return CheckAll(); }
        }
        public bool CheckNameOutput
        {
            get { return CheckName(); }
        }
        public bool CheckEmailOutput
        {
            get { return CheckEmail(); }
        }
        public bool CheckPasswordOutput
        {
            get { return CheckPassword(); }
        }
        public bool CheckTelOutput
        {
            get { return CheckTel(); }
        }
        public bool CheckAddessOutput
        {
            get { return CheckAddess(); }
        }
        public bool CheckNameToDuplicateOutput
        {
            get { return CheckNameToDuplicate(); }
        }
    }
}
