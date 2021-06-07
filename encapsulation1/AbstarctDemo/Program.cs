using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unable to create instance for Abstract
           // ClsPdfCreation clsPdfCreation = new ClsPdfCreation();
            AbsDerivedClass abs = new AbsDerivedClass();
            Console.WriteLine(abs.GetFilePath());
            Console.WriteLine(abs.GetFileDetails());
            Console.ReadLine();


        }
    }
    class AbsDerivedClass : ClsPdfCreation
    {
        public override string GetFilePath()


        {
            string filePath = @"C:\demo\testfile.txt";
            return filePath;
        }

        public override string GetFileDetails()
        {
            string fileContant = "this is after the virtual override";
            return fileContant;
        }
    }

}
