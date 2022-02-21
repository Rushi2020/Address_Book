using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");

            Address_Book address_Book = new Address_Book();


            string firstName = Console.ReadLine();
            Console.WriteLine("Enter first name");

            string lastName = Console.ReadLine();
            Console.WriteLine("Enter last name");

            string address = Console.ReadLine();
            Console.WriteLine("Enter address");

            string phoneNo = Console.ReadLine();
            Console.WriteLine("Enter phone no");

            string email = Console.ReadLine();
            Console.WriteLine("Enter email");

            string state = Console.ReadLine();
            Console.WriteLine("Enter state");

            string zip = Console.ReadLine();
            Console.WriteLine("Enter zip");

            address_Book.addContact(firstName, lastName, address, email, phoneNo, state, zip);






        }
    }
}