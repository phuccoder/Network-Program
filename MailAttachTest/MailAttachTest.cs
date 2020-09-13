using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mail;


namespace MailAttachTest
{
    class MailAttachTest
    {
        static void Main(string[] args)
        {
            MailAttachment myattach =
            new MailAttachment("c: \\temp\\test.txt", MailEncoding.Base64);
            MailMessage newmessage = new MailMessage();
            newmessage.From = "test1@test.com";
            newmessage.To = " test2@test.com ";
            newmessage.Subject = "A test mail attachment message";
            newmessage.Priority = MailPriority.High;
            newmessage.Headers.Add("Comments",
            "This message attempts to send a binary attachment");
            newmessage.Attachments.Add(myattach);
            newmessage.Body = "Here's a test file for you to try";
            try
            {
                SmtpMail.SmtpServer = "192.168.81.100";
                SmtpMail.Send(newmessage);
            }
            catch (System.Web.HttpException)
            {
                Console.WriteLine("This device cannot send Internet messages");
            }
        }
    }
}
