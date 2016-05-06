using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    class Bang
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
        }
        public void CreateACustomer()
        {
            Console.WriteLine("Enter Customer First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Customer Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter street address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter city name");
            string cityName = Console.ReadLine();
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter postal code");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            string phone = Console.ReadLine();
            string command = "INSERT INTO CUSTOMER (FirstName, LastName, StreetAddress, City, StateProvince, PostalCode, PhoneNumber) VALUES ('"+ firstName +"','"+ lastName +"','"+ address +"','"+ cityName +"','"+ state +"','"+ zip +"','"+ phone +"')";
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + "\"C:\\USERS\\AHMED\\DOCUMENTS\\VISUAL STUDIO 2015\\PROJECTS\\BANGAZON\\BANGAZON\\BANGAZONSTORE.MDF\"; Integrated Security = True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = command;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            Console.Clear();
            StartMenu();

        }
        public void PaymentOption()
        {
            Console.WriteLine("Enter payment type (e.g. AmEx, Visa, Checking)");
            Console.WriteLine("Enter account number");
        }
    }
}
