using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Crud
{
  public class AddEmail
    {
        Validation validation = new Validation();
        public void AddEmailDetails(List<Email> emails)
        {
            int emailId = 0;
            Console.WriteLine("Enter Name");
            string ? name = Console.ReadLine();
            name = validation.CheckName(name);
            Console.WriteLine("Enter Email");
            string ? emailAddress = Console.ReadLine();
            emailAddress = validation.CheckEmail(emailAddress);
            
            if (emails.Count == 0)
            {

                emailId = 1;
            }
            else
            {
                emailId = emails.Max(e =>e.EmailId);
                emailId++;
            }
            Email obj = new Email(emailId, name, emailAddress);
    
            emails.Add(obj);
            Console.WriteLine("Email Added Successfully");
        }
    }
}
