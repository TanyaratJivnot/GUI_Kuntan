using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShop
{
    class Tablecat
    {
        //ประกาศตัวเเปรเพื่อทำการเก็บค่าต่างๆ
        private int ID;
        private string Picture;
        private string Species;
        private string Sex;
        private string Eyes;
        private string Price;
        public Tablecat()
        {

        }
        
        public Tablecat(int id,string picture, string species, string sex, string eyes, string price)//สร้างคอนสตัคเตอร์เพื่อทำการรับค่าลงตารางหรือดึงข้อมูล
        {
            ID = id;
            Picture = picture;
            Species = species;
            Sex = sex;
            Eyes = eyes;
            Price = price;
            CreateTableCustomer();
            InsertToTableCustomer();
        }
        private void CreateTableCustomer()//สร้างตารางเก็บข้อมูลลูกค้า
        {
            //using ใช้เพื่อกำหนดขอบเขตการทำงาน และจะคืนพื้นที่ให้ ram เมื่อจบการทำงานของ using
            //SqliteConnection ชื่อ = new SqliteConnection( " ที่อยู่ไฟล์ .db " );
            using (SqliteConnection db = new SqliteConnection("Filename=CatShop.db"))//เริ่มต้นการทำงาน เก็บข้อมูลไว้ใน ram
            {
                db.Open();//เปิดการเชื่อมต่อ
                string CatDB = "CREATE TABLE IF NOT " +
                                      "EXISTS CatDB (ID INTEGER PRIMARY KEY(ID AUTOINCREMENT)," +
                                      "Picture TEXT," +
                                      "Species TEXT," +
                                      "Sex TEXT," +
                                      "Eyes TEXT," +
                                      "Price TEXT);";
                //คำสั่งsqlie
                SqliteCommand sqliteCommand = new SqliteCommand(CatDB, db);
                //SqliteCommand create = new SqliteCommand(คำสั่งที่ต้องการให้ทำงาน , DataBase Connection); ส่งคำสั่ง SQL ไปทำงาน
                sqliteCommand.ExecuteReader();//run คำสั่ง SQL
            }
        }
        private void InsertToTableCustomer()//อินเสริชข้อมูลเข้าตาราง
        {
            using (SqliteConnection db = new SqliteConnection("Filename=CatShop.db"))
            {
                db.Open();
                SqliteCommand sqliteCommand = new SqliteCommand();//สำหรับส่งคำสั่ง SQL ไปทำงาน
                sqliteCommand.Connection = db;//DataBase ที่เชื่อมต่ออยู่

                sqliteCommand.CommandText = "INSERT INTO CatDB VALUES (@ID,@Picture,@Species,@Sex,@Eyes,@Price)";//คำสั่ง SQL
                //เก็บตัวแปรไว้ใน@....เพื่อทำการไม่ให้ผู้ใช้ใส่คำสั่งที่เป็นการทำลายฐานข้อมูลที่เราสร้างขึ้น
                sqliteCommand.Parameters.AddWithValue("@ID", Picture);
                sqliteCommand.Parameters.AddWithValue("@Picture", Picture);
                sqliteCommand.Parameters.AddWithValue("@Species", Species);
                sqliteCommand.Parameters.AddWithValue("@Sex", Sex);
                sqliteCommand.Parameters.AddWithValue("@Eyes", Eyes);
                sqliteCommand.Parameters.AddWithValue("@Price", Price);

                sqliteCommand.ExecuteReader();
                db.Close();//ปิดการทำงาน
            }
        }
    }
}
