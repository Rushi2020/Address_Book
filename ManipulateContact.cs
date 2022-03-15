using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Address_Book
{
     class ManipulateContact
    {
       public List<Contact>AddressBookList= new List<Contact>();
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

        public void SearchinginCity(string City)
        {
            Console.Write($"{City}: ");
            foreach (var contact in AddressBookList)
            {
                if (contact.city.Contains(City))
                {
                    Console.Write($"{contact.firstname}, ");
                }
            }
        }

        public void SearchingInState(String City)
        {
            List<Contact> CityBookList = new List<Contact>();
            CityBookList = AddressBookList.FindAll(x => x.city.Contains(City) || x.state.Contains(City));

            foreach (var contact in CityBookList)
            {
                Console.Write($"{contact.firstname}, ");
            }
            int Count = CityBookList.Count;
            Console.Write($"\ntotal people: {Count}\n ");
        }


    }
}