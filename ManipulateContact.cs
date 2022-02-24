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
            string firstname,
            string lastname,
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
                    firstName = firstname,
                    address = Address,
                    city = City,
                    state = State,
                    zip = ZipCode,
                    phoneno = PhoneNumber,
                    email = Email
                }
            );
            Console.WriteLine($"{firstname} is added");
        }
    }
}