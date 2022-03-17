using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
   public class Contact
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string phoneno { get; set; }
        public string email { get; set; }
        public string state { get; set; } 
        public string zip { get;  set; }

        public override string ToString()
        {
            return $"{this.firstname} {this.lastname} {this.address}  {this.city}  {this.state}  {this.zip}  {this.phoneno}  {this.email}";
        }
    }

}

