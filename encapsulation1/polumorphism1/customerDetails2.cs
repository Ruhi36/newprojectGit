using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polumorphism1
{

    public class staticDemo
    {
        public int GetStudentId(string Name)
        {

            if (Name == "Sachin")
            {
                return 321;
            }
            else
            {
                return 654;
            }
            
        }

        public static int GetStudentId(String Name, String Location)

        {
           
            if (Name == "sachin" && Location.Equals("Mumbai"))
            {
                return 321;
            }
            else
            {
                return 654;
            }
           
        }
    }

}
