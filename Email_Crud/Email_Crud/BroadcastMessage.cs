using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Email_Crud
{
    public class BroadcastMessage
    {
        List<Email> BroadcastMail = new List<Email>();
        Validation validation = new Validation(); 
        public BroadcastMessage(List<Email> email)
        {
            BroadcastMail = email;
        }
        public void BroadMeaasge()
        {
            Console.WriteLine("Enter Subject For Broadcast");
            string ? subject = Console.ReadLine();
            subject = validation.CheckSubject(subject);
            Console.WriteLine("Enter Body of the Broadcast");
            string ? body = Console.ReadLine();
            body = validation.CheckBody(body);
            foreach (Email email in BroadcastMail)
            {

                Thread emailThread = new Thread(() =>
                {
                    // Create a  SmtpClient object
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("pawank.aspirefox@gmail.com", "eftxaasvaejrqyfw");

                    // Create a new MailMessage object
                    MailMessage message = new MailMessage("pawank.aspirefox@gmail.com", email.EmailAddress, subject, body);
                    try
                    {
                        // Send the email
                        client.Send(message);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error sending email: " + ex.Message);
                    }

                });


                // Start the email thread
                emailThread.Start();

                // Wait for the email thread to finish
                emailThread.Join();
                Console.WriteLine("Email sent successfully.");

            }

        }

    }
}

