using System;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");

            Contact detail = new Contact();
            ManipulateContact AddContact = new ManipulateContact();
            AddContact.AddingContact(
                detail.firstName = Console.ReadLine(),
                detail.lastName = Console.ReadLine(),
                detail.address = Console.ReadLine(),
                detail.city = Console.ReadLine(),
                detail.state = Console.ReadLine(),
                detail.zip = Console.ReadLine(),
                detail.phoneno = Console.ReadLine(),
                detail.email = Console.ReadLine()
                ); 
        }
    }
}