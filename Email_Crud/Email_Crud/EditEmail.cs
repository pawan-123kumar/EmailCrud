using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Crud
{
    public class EditEmail
    {
        Validation validation = new Validation();
        List<Email> editList = new List<Email>();
        public EditEmail(List<Email> emlList)
        {
            this.editList = emlList;
        }
        public void EditEmailDetails()
        {
            Console.WriteLine("Enter EmailId For Edit");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please Provide Valid EmailId");
            }
            Email? editEmail = editList.FirstOrDefault(e => e.EmailId == id);
            if (editEmail != null)
            {
                Console.WriteLine("Enter 1 for Edit The Name");
                Console.WriteLine("Enter 2 for Edit The Email");
                Console.WriteLine("Enetr 3 for Both Name And Email");
                Console.WriteLine("Enter 4. for Exit");
                Console.WriteLine("Please Select Your choice");
                bool flag = true;
                while (flag)
                {    
                    int x;
                    while(!int.TryParse(Console.ReadLine(),out x))
                    {
                        Console.WriteLine("Please Enter a Valid Number");
                    }
                    switch (x)
                    {
                        case 1:
                            Console.WriteLine("Enter Name");
                            string? name = Console.ReadLine();
                            name = validation.CheckName(name);
                            editEmail.Name = name;
                            Console.WriteLine("Name Updated Successfully Please Select 2 for View the List");
                            flag = false;
                            break;
                        case 2:
                            Console.WriteLine("Enter Email");
                            string? email = Console.ReadLine();
                            email = validation.CheckEmail(email);
                            editEmail.EmailAddress = email;
                            Console.WriteLine("Email Updated Successfully Please Select 2 for View the List");
                            flag = false;
                            break;
                        case 3:
                            Console.WriteLine("Enter Name");
                            string? name1 = Console.ReadLine();
                            name = validation.CheckName(name1);
                            editEmail.Name = name;
                            Console.WriteLine("Enter Email");
                            string? email1 = Console.ReadLine();
                            email = validation.CheckEmail(email1);
                            editEmail.EmailAddress = email;
                            Console.WriteLine("List Updated Successfully Please Select 2 for View the List");
                            flag = false;
                            break;
                        case 4:
                            Console.WriteLine("Exit Menu");
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Please Select a valid Options");
                            break;
                    
                    }
                }
               
            }
            else
                Console.WriteLine("Email not found please Enter a valid EmailId");
        }
    }
}
