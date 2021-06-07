using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation1
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount obj = new BankAccount();
            CustomerDeatils customer = new CustomerDeatils();
            obj.GetCustomerDeatils();
           

        }
    }
    class BankAccount
    {
        public CustomerDeatils GetCustomerDeatils()
        {
            CustomerDeatils customer = new CustomerDeatils();
            customer.AccountNumber= 3749684995789;
            customer.CustomerName = "Ruhi";
             Console.WriteLine("Account number is:" + customer.AccountNumber);
             Console.WriteLine("customer name is: " + customer.CustomerName);
           // Console.WriteLine("Enter AccountNumber");

           

            //customer.Atmpin=5454;
            return customer;
        }
    }
}
