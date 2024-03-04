using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Customer
    {
        private static int CustomerID;
        private static string Name;
        private static int Age;
        private static int PhoneNo;
        private static string City;

        public Customer()
        {

        }
        public Customer(int CustId, string name, int age, int Phno, string city)
        {
            CustomerID = CustId;
            Name = name;
            Age = age;
            PhoneNo = Phno;
            City = city;
        }

        static void DisplayCustomer()
        {
            Console.WriteLine($"Customer Id: {CustomerID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone Number: {PhoneNo}");
            Console.WriteLine($"City: {City}");
        }
        ~Customer()       // ~ for destructor
        {
            Console.WriteLine("object destroy");
            Console.Read();
        }
        public static void Main()
            {
                Customer customer1 = new Customer(9, "Sanju", 21, 8378326, "Lucknow");
                Customer.DisplayCustomer();
                Console.Read();
            }

        }
     }


