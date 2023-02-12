using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShop
{
    class DetailCat
    {
        //คลาสนี้เรียกใช้ในการเก็บค่าข้อมูลลุกค้าเเละคืนค่าที่ลูกค้าเลือกเเมว
        private string Species;
        private string eyes;
        private string Price;
        private string sex;
        private string chang;
        public DetailCat(string Species,string Price, string eyes, string sex)
        {
            this.Species = Species;
            this.Price = Price;
            this.eyes = eyes;
            this.sex = sex;
        }
        public DetailCat(string chang)
        {
            this.chang = chang;
        }
        public string SpeciesCat
        {
            get { return Species; }
            set { Species = value; }
        }
        public string eyesCat
        {
            get { return eyes; }
            set { eyes = value; }
        }
        public string PriceCat
        {
            get { return Price; }
            set { Price = value; }
        }
        public string SexCat
        {
            get { return sex; }
            set { sex = value; }
        }
        public string ChangCatMoney
        {
            get { return chang; }
            set { chang = value; }
        }
        public string AllDetail()//รีเทรินค่าทั้งหมด
        {
            return Species+","+eyes+","+sex+","+Price;
        }
        public string AllChang()
        {
            return chang;
        }
    }
}
