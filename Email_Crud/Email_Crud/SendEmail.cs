using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Email_Crud
{
   public class SendEmail
    {
        List<Email> Emp = new List<Email>();
        Validation validation = new Validation();
        public SendEmail(List<Email> empList)
        {
            this.Emp = empList;
        }
        public void sendMailEmp()
        {

            Console.WriteLine("Please Enter EmailId For Send the Email:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please Provide Valid Input");
            }
            //Use Linq Lambda operator
            Email? sendMail = Emp.FirstOrDefault(e => e.EmailId == id);
            if (sendMail != null)
            {
                Console.WriteLine("please enter subject for the email");
                string? subject = Console.ReadLine();
                subject = validation.CheckSubject(subject);
                Console.WriteLine("Please enter body of the email");
                string? body = Console.ReadLine();

                body = validation.CheckBody(body);
                    // Create a new SmtpClient object
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("pawank.aspirefox@gmail.com", "eftxaasvaejrqyfw");

                    // Create a new MailMessage object
                    MailMessage message = new MailMessage("pawank.aspirefox@gmail.com", sendMail.EmailAddress, subject, body);

                    try
                    {
                        // Send the email
                        client.Send(message);
                        Console.WriteLine("Email sent successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error sending email: " + ex.Message);
                    }
            }
            else
                Console.WriteLine("Email not found on this location");

        }
    }
}
