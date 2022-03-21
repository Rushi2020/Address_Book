using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book.Services
{
    public class AddressBookIO
    {
        public const string TxtPath = @"C:\Users\Rushikesh\source\repos\Address_Book\Utility/sample.txt";
        public void SimpleWrite(List<Contact> AddressBookList)
        {
            File.WriteAllText(TxtPath, string.Empty);
            foreach(Contact contact in AddressBookList)
            {
                File.AppendAllText(TxtPath, contact.ToString() + Environment.NewLine);
                Console.WriteLine("file Read");
                SimpleRead();
            }
        }

        public static void SimpleRead()
        {
            string lines = File.ReadAllText(TxtPath);
            Console.WriteLine(lines);
        }
    }
}
