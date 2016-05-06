using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            Bang bang = new Bang();
            bang.StartMenu();
            string line = Console.ReadLine();
            switch(line)
            {
                case "1": bang.CreateACustomer();
                    break;
            }
        }
    }
}