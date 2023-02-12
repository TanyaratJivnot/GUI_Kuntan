using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShop
{
    class SingUpCustomerDB
    {
        private string Name;
        private string Email;
        private string Password;
        private string Tel;
        private string Addess;
        public SingUpCustomerDB(string name, string mail, string password, string tel, string addess)
        {
            Name = name;
            Email = mail;
            Password = password;
            Tel = tel;
            Addess = addess;

            CreateTableCustomer();
            InsertToTableCustomer();

        }

        private void CreateTableCustomer()//สร้างตารางเก็บข้อมูลลูกค้า
        {
            using (SqliteConnection db = new SqliteConnection("Filename=TableCustomer.db"))
            {
                db.Open();
                string CustomerDB = "CREATE TABLE IF NOT " +
                                      "EXISTS Customer (Name NVACHAR(20) Primary Key," +
                                      "Email NVACHAR(30)," +
                                      "Password NVACHAR(13)," +
                                      "Tel NVACHAR(10)," +
                                      "Addess NVACHAR(100));";
                SqliteCommand sqliteCommand = new SqliteCommand(CustomerDB, db);
                sqliteCommand.ExecuteReader();
            }
        }
        private void InsertToTableCustomer()//อินเสริชข้อมูลเข้าตาราง
        {
            using (SqliteConnection db = new SqliteConnection("Filename=TableCustomer.db"))
            {
                db.Open();
                SqliteCommand sqliteCommand = new SqliteCommand();
                sqliteCommand.Connection = db;

                sqliteCommand.CommandText = "INSERT INTO Customer VALUES (@Name,@Email,@Password,@Tel,@Addess)";
                sqliteCommand.Parameters.AddWithValue("@Name", Name);
                sqliteCommand.Parameters.AddWithValue("@Email", Email);
                sqliteCommand.Parameters.AddWithValue("@Password", Password);
                sqliteCommand.Parameters.AddWithValue("@Tel", Tel);
                sqliteCommand.Parameters.AddWithValue("@Addess", Addess);

                sqliteCommand.ExecuteReader();
                db.Close();
            }
        }
    }
}
