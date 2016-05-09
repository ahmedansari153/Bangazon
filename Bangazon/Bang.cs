using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    public class Bang
    {
        public void StartMenu()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("**Welcome to Bangazon! Command Line Ordering System**");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("1.Create an account");
            Console.WriteLine("2.Create a payment option");
            Console.WriteLine("3.Order a product");
            Console.WriteLine("4.Complete an order");
            Console.WriteLine("5.See product popularity");
            Console.WriteLine("6.Leave Bangazon!");
            string line = Console.ReadLine();
            Customer customer = new Customer();
            switch (line)
            {
                case "1":
                    customer.CreateACustomer();
                    break;
                case "2":
                    customer.ChooseACustomer();

                    break;
            }
        }
    }
}
