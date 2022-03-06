using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class ContactOptions
    {
        Dictionary<string, ManipulateContact> MultiAddressBook = new Dictionary<string, ManipulateContact>();


        public static ManipulateContact manipulate = new ManipulateContact();
        public void AddContact(string BookName)
        {
            Console.Write($"how many contacts do you want to add: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write("enter name: ");
                string Name = Console.ReadLine();
                Console.Write("enter address: ");
                string Address = Console.ReadLine();
                Console.Write("enter city: ");
                string City = Console.ReadLine();
                Console.Write("enter state: ");
                string State = Console.ReadLine();
                Console.Write("enter zip code: ");
                string ZipCode = Console.ReadLine();
                Console.Write("enter phone number: ");
                string PhoneNumber = Console.ReadLine();
                Console.Write("enter email id: ");
                string Email = Console.ReadLine();
                Contact detail = new Contact();
                MultiAddressBook.Add(BookName + i, manipulate);
                manipulate.AddingContact(
                    detail.firstname = Name,
                    detail.address = Address,
                    detail.city = City,
                    detail.state = State,
                    detail.zip = ZipCode,
                    detail.phoneno = PhoneNumber,
                    detail.email = Email
                    );
            }
        }

        public void EditContact()
        {
            Console.Write("enter name you want edit: ");
            string Name = Console.ReadLine();
            manipulate.EditingContact(Name);
        }
        public void DeleteContact()
        {
            Console.Write("enter name you want delete: ");
            string Name = Console.ReadLine();
            manipulate.DeletingContact(Name);
        }
    }
}
