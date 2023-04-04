using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Crud
{
   public class DeleteEmail
    {
        List<Email> emailList = new List<Email>();
        public DeleteEmail(List<Email> emlList)
        {
            this.emailList = emlList;
        }
        public void DeleteEmailDetails()
        {
            Console.WriteLine("Enter EmailId For Delete");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please Provide Valid Input");
            }
            //Use Linq Lambda Operator

            Email? deleteIndex = emailList.FirstOrDefault(e => e.EmailId == id);
            if (deleteIndex != null)
            {
                Console.WriteLine("Are You Confirm  To Delete please enter yes for Delete or no for cancel");
                string? conf = Console.ReadLine();
                if (conf != null)
                {
                    if (conf == "yes" || conf == "Yes" || conf == "YES" || conf == "yES" || conf == "yeS" || conf == "YEs")
                    {
                        emailList.Remove(deleteIndex);
                        Console.WriteLine("Email deleted successfully! \n");
                    }
                    else
                        Console.WriteLine("Email are not Deleted\n");
                }
            }
            else
            {
                Console.WriteLine("Email not found! List is already Empty please select 1 To add The Email \n");
            }
        }
    }
    }

