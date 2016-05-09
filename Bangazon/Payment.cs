using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
   public class Payment
    {
        public void PaymentOption()
        {
            Console.WriteLine("Enter payment type (e.g. AmEx, Visa, Checking)");
            Console.WriteLine("Enter account number");
            Console.ReadLine();
        }
    }
}
