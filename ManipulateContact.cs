using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class ManipulateContact
    {
        List<Contact> AddressBookList = new List<Contact>();
        public void AddingContact
            (
            string Name,
            string Address,
            string City,
            string State,
            string ZipCode,
            string PhoneNumber,
            string Email
            )
        {
            AddressBookList.Add
                (new Contact()
                {
                    firstname = Name,
                    address = Address,
                    city = City,
                    state = State,
                    zip = ZipCode,
                    phoneno = PhoneNumber,
                    email = Email
                }
            );
            Console.WriteLine($"{Name} is added___________");
        }


        public void EditingContact(string Name)
        {
            foreach (var contact in AddressBookList)
            {
                if (contact.firstname.Contains(Name))
                {
                    
                    Console.WriteLine("plz provide new phone number");
                    contact.phoneno = Console.ReadLine();
                    Console.WriteLine("plz provide new email");
                    contact.email = Console.ReadLine();
                    Console.WriteLine("plz provide new email");
                    contact.address = Console.ReadLine();
                    Console.WriteLine("plz provide new email");
                    contact.city = Console.ReadLine();
                }
            }
        }

        public void DeletingContact(string Name)
        {
            foreach (var contact in AddressBookList)
            {
                if (contact.firstname.Contains(Name))
                {
                    AddressBookList.Remove(contact);
                    Console.WriteLine($"{Name}'s Contact is deleted");
                    break;
                }
            }
        }
    }
}