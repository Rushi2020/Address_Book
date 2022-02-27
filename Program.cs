// See https://aka.ms/new-console-template for more information
using System;

namespace Address_Book
{
    internal class Program
    {
        public static ManipulateContact manipulate = new ManipulateContact();

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book system");

            AddContact();
            EditContact();
        }

        public static void AddContact()
        {
            Console.WriteLine("how many contacts do you want to add?");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Contact detail = new Contact();
                
                manipulate.AddingContact(
                    detail.firstname = Console.ReadLine(),
                    detail.address = Console.ReadLine(),
                    detail.city = Console.ReadLine(),
                    detail.state = Console.ReadLine(),
                    detail.zip = Console.ReadLine(),
                    detail.phoneno = Console.ReadLine(),
                    detail.email = Console.ReadLine()
                    );

            }
        }

        public static void EditContact()
        {
            Console.WriteLine("enter name you want edit");
            string firstname = Console.ReadLine();
            manipulate.EditingContact(firstname);
        }
    }
}