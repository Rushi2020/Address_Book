using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Address_Book
    {
        List<Contact> contacts = new List<Contact>();

        public void  addContact(string firstname, string lastname, string address, string email, string no, String state, string zip)
        {
            contacts.Add(new Contact()
            {

                phoneno = no,
                firstName = firstname,
                lastName = lastname,
                email = email,
                address = address,
                state = state,
                zip = zip,
            });
            Console.WriteLine("$Contact of {firstName} has been add.");
        }

    }
}