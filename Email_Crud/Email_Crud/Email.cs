using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Crud
{
     public class Email
    {
      public  int EmailId { get; set; }
       public string Name { get; set; }
       public string EmailAddress { get; set; }

        public Email(int email_id, string name,string email_address)
        {
            EmailId = email_id;
            Name = name;
            EmailAddress = email_address;
        }
    }
}
