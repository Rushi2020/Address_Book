using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book.Services
{
    internal class JsonIO
    {
        public const string JsonPath = @"C:\Users\Rushikesh\source\repos\Address_Book\Utility\Contacts.Json";


        public void JsonWrite(List<Contact> AddressBookList)
        {
            File.WriteAllText(JsonPath, string.Empty);
            foreach (var book in AddressBookList)
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                var stream = File.Open(JsonPath, FileMode.Append);
                using (var streamwriter = new StreamWriter(stream))
                using (var jsonwriter = new JsonTextWriter(streamwriter))
                {
                    foreach (Contact contact in AddressBookList)
                    {
                        jsonSerializer.Serialize(jsonwriter, contact);
                    }
                }
            }
            JsonRead();
        }
        public static void JsonRead()
        {
            Contact contact = JsonConvert.DeserializeObject<Contact>(File.ReadAllText(JsonPath));
            Console.WriteLine(contact.ToString());
        }
    }
}
