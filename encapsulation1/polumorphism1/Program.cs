using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polumorphism1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Normal process
            //StaticDemo obj = new StaticDemo();
            //obj.GetStudentId("Sachin");
            ////static
            //StaticDemo.GetStudentId("Sachin", "Mumbai");j
            //customerDetails customer = new customerDetails();
            //bool res = customer.Getcash("565656");
            //bool res2 = customer.Getcash(5555555);
            //bool res3 = customer.Getcash("565656", 5555555);
            staticDemo obj = new staticDemo();
            obj.GetStudentId("Sachin");
            staticDemo.GetStudentId("Sachin", "Mumbai");
          


        }
    }
    public class StudentDetails
    {
        //overloading constructor
        public StudentDetails(int number)
        {

        }
        public StudentDetails(string name)
        {

        }

    }
}
