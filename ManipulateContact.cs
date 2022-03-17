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
        public List<Contact> AddressBookList = new List<Contact>();
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

        public void SortingAddessBook(int Option)
        {
            Sorting sorting = new Sorting();

            switch (Option)
            {
                case 1:
                    sorting.Details = Sorting.SortingType.NAME;
                    break;
                case 2:
                    sorting.Details = Sorting.SortingType.CITY;
                    break;
                case 3:
                    sorting.Details = Sorting.SortingType.STATE;
                    break;
                case 4:
                    sorting.Details = Sorting.SortingType.ZIP;
                    break;
            }
            AddressBookList.Sort(sorting);

            foreach (var contact in AddressBookList)
            {
                Console.WriteLine($"firstname: {contact.firstname} lastname: {contact.lastname} city: {contact.city}  state: {contact.state}  zip: {contact.zip}");
            }
        }
    }

          public class Sorting : IComparer<Contact>
          {
              public enum SortingType
              {
                 NAME, CITY, STATE, ZIP
              }
              public SortingType Details;
            public int Compare(Contact x, Contact y)
            {
              switch (Details)
              {
                  case SortingType.NAME:
                      return x.firstname.CompareTo(y.firstname);
                      break;
                  case SortingType.CITY:
                      return x.city.CompareTo(y.city);
                      break;
                  case SortingType.STATE:
                      return x.state.CompareTo(y.state);
                      break;
                  case SortingType.ZIP:
                      return x.zip.CompareTo(y.zip);
                      break;
                  default:
                      break;

              }
                   return x.firstname.CompareTo(y.lastname);
            }  
          }
    
}

