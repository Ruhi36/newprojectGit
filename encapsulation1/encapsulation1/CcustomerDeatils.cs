using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation1
{
    public class CustomerDeatils
    {
        public long AccountNumber { get; set; }
        public string CustomerName { get; set; }
        private int AtmPin { get; set; }
        private bool Getcash(long AccountNumber)
        {
            if(AccountNumber==5555555)
            {
                if(AtmPin==5454)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            return false;
        }
    }
}
