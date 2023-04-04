using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Crud
{
    public class program
    {

        static void Main(string[]args)
        {
            List<Email> emails = new List<Email>();

         
            bool select = true;
            while (select)
            {
                Console.WriteLine("1.Add Email");
                Console.WriteLine("2.View Email List");
                Console.WriteLine("3.Delete Email");
                Console.WriteLine("4.Edit Email");
                Console.WriteLine("5.Send Email");
                Console.WriteLine("6.Broadcast Message");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Please Select Your Choice");
                Console.WriteLine();
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please Enter a Valid Number");
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add Email");
                        AddEmail eml = new AddEmail();
                        eml.AddEmailDetails(emails);
                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("View Email list");
                        ViewEmailList view = new ViewEmailList(emails);
                        view.ShowEmail();

                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Delete Email");
                        DeleteEmail deleEmail = new DeleteEmail(emails);
                        deleEmail.DeleteEmailDetails();
                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Edit Email");

                        EditEmail editmail = new EditEmail(emails);
                        ViewEmailList view1 = new ViewEmailList(emails);
                        view1.ShowEmail();
                        editmail.EditEmailDetails();
                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Send Email");
                        ViewEmailList view2 = new ViewEmailList(emails);
                        view2.ShowEmail();
                        SendEmail send = new SendEmail(emails);
                        send.sendMailEmp();
                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Broadcast Message");
                        BroadcastMessage message = new BroadcastMessage(emails);
                        message.BroadMeaasge();
                        Console.WriteLine("\nPress Enter to get back to main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Exit");
                        select = false;
                        break;
                    default:
                        Console.WriteLine("Please Select a valid option");
                        break;
                }        
            }
        }
    }
}