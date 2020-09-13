using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MailAttachTest2
{
    class MailAttachTest2
    {
        static void Main(string[] args)
        {
            string file1 = "test1.jpg";
            string file2 = "test2.doc";
            SmtpClient SmtpMail = new SmtpClient();
            Attachment f1 = new Attachment(file1);
            Attachment f2 = new Attachment(file2);
            MailMessage newmessage = new MailMessage("test1@test.com", "test2@test.com",
           "A test mail attachment message", "TEST MAIL");
            newmessage.Priority = MailPriority.High;
            newmessage.Headers.Add("Comments", "This message attempts to send a picture, a text document attachments");

            newmessage.Attachments.Add(f1);
            newmessage.Attachments.Add(f2);
            try
            {
                SmtpMail.Host = "192.168. 81. 100";
                SmtpMail.Send(newmessage);
            }
            catch (System.Net.HttpListenerException)
            {
                Console.WriteLine("This device cannot send Internet messages");
            }
        }
    }
}
