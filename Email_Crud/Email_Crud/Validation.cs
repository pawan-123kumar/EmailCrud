using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Email_Crud
{
    public class Validation
    {
        string pattern = @"^[A-Za-z\s]+$";
        string email_pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        public string CheckName(string ? name)
        {
            while(!Regex.IsMatch(name ?? " ",pattern))
            {
                Console.WriteLine("Invalid Name Please Enter a Valid Name");
                name = Console.ReadLine();
            }
            return name ?? " ";
        }
        public string CheckEmail(string ? email)
        {
            while (!Regex.IsMatch(email ?? " ", email_pattern))
            {
                Console.WriteLine("Invalid Email Please Enter a Valid EmailAddress");
                email = Console.ReadLine();
            }
           
            return email ?? " ";
        }
        public string CheckSubject(string? subject)
        {
            while (!Regex.IsMatch(subject ?? " ", pattern))
            {
                Console.WriteLine("Invalid Subject Please Enter Correct Subject For Send The Email");
                subject = Console.ReadLine();
            }
            return subject ?? " ";
        } public string CheckBody(string? body)
        {
            while (!Regex.IsMatch(body ?? " ", pattern))
            {
                Console.WriteLine("Invalid Subject Please Enter Correct Subject For Send The Email");
                body = Console.ReadLine();
            }
            return body ?? " ";
        }
    }
}
