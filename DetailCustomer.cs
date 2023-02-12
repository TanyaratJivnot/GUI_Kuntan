using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShop
{
    class DetailCustomer
    {
        //คลาสนี้เรียกใช้ในการเก็บค่าข้อมูลลุกค้าเเละคืนค่าที่ผู้ใช้ใส่เข้ามา
        private string Name;
        private string Eamil;
        private string Tel;
        private string Address;
        public DetailCustomer(string Name, string Eamil, string Tel, string Address)
        {
            this.Name = Name;
            this.Eamil = Eamil;
            this.Tel = Tel;
            this.Address = Address;
        }
        public string NameCus
        {
            get { return Name; }
            set { Name = value; }
        }
        public string MailCus
        {
            get { return Eamil; }
            set { Eamil = value; }
        }
        public string PhonCus
        {
            get { return Tel; }
            set { Tel = value; }
        }
        public string Add
        {
            get { return Address; }
            set { Address = value; }
        }
        public string AllCustomer()//รีเทรินค่าทั้งหมด
        {
            return Name + "," + Eamil + "," + Tel + "," + Address;
        }
    }
}

