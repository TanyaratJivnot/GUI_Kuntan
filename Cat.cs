using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShop
{
    class Cat
    {
        private int ID;
        private string Picture;
        private string Species;
        private string Sex;
        private string Eyes;
        private string Price;
        public Cat()
        {

        }
        public Cat(string Species, string Sex, string Eyes, string Price)
        {
            this.Species = Species;
            this.Sex = Sex;
            this.Eyes = Eyes;
            this.Price = Price;
        }
        public string Photo
        {
            get { return Picture; }
            set { Picture = value; }
        }
        public string SpeciesCat
        {
            get { return Species; }
            set { Species = value; }
        }
        public string SexCat
        {
            get { return Sex; }
            set { Sex = value; }
        }
        public string EyesCat
        {
            get { return Eyes; }
            set { Eyes = value; }
        }
        public string PriceCat
        {
            get { return Price; }
            set { Price = value; }
        }
    }
}
