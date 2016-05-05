using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    class Program
    {
        public void SqlConnection()
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ahmed\\documents\visual studio 2015\\Projects\\Bangazon\\Bangazon\\BangazonStore.mdf\";Integrated Security = True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
           
        }
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
        }
        public void CreateACustomer()
        {
            Console.WriteLine("Enter Customer First Name");
            Console.ReadLine();
            Console.WriteLine("Enter Customer Last Name");
            Console.ReadLine();
            Console.WriteLine("Enter street address");
            Console.ReadLine();
            Console.WriteLine("Enter city name");
            Console.ReadLine();
            Console.WriteLine("Enter state");
            Console.ReadLine();
            Console.WriteLine("Enter postal code");
            Console.ReadLine();
            Console.WriteLine("Enter phone number");
            Console.ReadLine();
        }
        public void PaymentOption()
        {
            Console.WriteLine("Enter payment type (e.g. AmEx, Visa, Checking)");
            Console.WriteLine("Enter account number");
        }
    }
}