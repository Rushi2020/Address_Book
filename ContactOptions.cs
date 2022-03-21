using Address_Book.Services;
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
                bool Duplicate = false;

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




                foreach (var contact in manipulate.AddressBookList)
                {
                    if (contact.firstname.Contains(Name))
                    {
                        Duplicate = true;
                    }
                }
                if (!Duplicate)
                {
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
                else
                {
                    Console.WriteLine("contact name already exists");
                    num++;
                }

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
        public void SearchinCity()
        {
            Console.Write("enter city name you want search : ");
            string City = Console.ReadLine();
            manipulate.SearchinginCity(City);
        }

        public void SearchInState()
        {
            Console.Write("enter city/state name you want search in: ");
            string City = Console.ReadLine();
            manipulate.SearchingInState(City);
        }

        public void SortContact()
        {
            Console.Write("enter sort by 1) name 2) city 3) state 4) zip: ");
            int Option = Convert.ToInt32(Console.ReadLine());
            manipulate.SortingAddessBook(Option);
        }

        public void FileWrite()
        {
            AddessBookIO addessBookIO = new AddessBookIO();
            addessBookIO.SimpleWrite(manipulate.AddressBookList);
        }

    }
}
