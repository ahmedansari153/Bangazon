using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    public class Customer
    {
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
            string command = "INSERT INTO CUSTOMER (FirstName, LastName, StreetAddress, City, StateProvince, PostalCode, PhoneNumber) VALUES ('" + firstName + "','" + lastName + "','" + address + "','" + cityName + "','" + state + "','" + zip + "','" + phone + "')";
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + "\"C:\\USERS\\AHMED\\DOCUMENTS\\VISUAL STUDIO 2015\\PROJECTS\\BANGAZON\\BANGAZON\\BANGAZONSTORE.MDF\"; Integrated Security = True");

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = command;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            Console.Clear();
            Bang bang = new Bang();
            bang.StartMenu();
        }
        public void ChooseACustomer()
        {
            Console.Clear();
            Console.WriteLine("Choose a customer");
            string command = @"
SELECT
IdCustomer,
FirstName + ' ' + LastName
FROM Customer c";
            using (SqlConnection sqlConnection2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + "\"C:\\USERS\\AHMED\\DOCUMENTS\\VISUAL STUDIO 2015\\PROJECTS\\BANGAZON\\BANGAZON\\BANGAZONSTORE.MDF\"; Integrated Security = True"))
            using (SqlCommand cmd = new SqlCommand(command, sqlConnection2))
            {
                sqlConnection2.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            Console.WriteLine("{0}.) {1}",
                                reader[0], reader[1]);
                        }
                    }
                }

            }
            Console.ReadLine();
            Console.Clear();
            Payment payment = new Payment();
            payment.PaymentOption();
        }
    }
}
