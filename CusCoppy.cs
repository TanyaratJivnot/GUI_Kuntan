using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShop
{
    class CusCoppy
    {
        //คลาสสำหรับการอ่านและเขียนข้อมูลลงในtextfile
        private string fileName;
        public CusCoppy(string fileName)
        {
            this.fileName = fileName;
        }
        public List<string> ReadFile()//เมธอดการอ่านไฟล์
        {
            List<string> texts = new List<string>();
            try
            {
                string[] fileContent = File.ReadAllLines(fileName);//คำสั่งอ่านทั้งหมด
                texts.AddRange(fileContent);
                return texts;
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                return texts;
            }
        }
        public void WriteFile(List<string> texts)//เขียนทับข้อมูลเก่า
        {
            try
            {
                File.WriteAllLines(fileName, texts);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
        public void WriteFileAappen(List<string> texts)//เขียนต่อจากข้อมูลเดิม
        {
            try
            {
                File.AppendAllLines(fileName, texts);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
