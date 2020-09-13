using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace MailTest2
{
    class MailTest2
    {
        static void Main(string[] args)
        {
            SmtpClient SmtpMail = new SmtpClient();
            string from = "test1@test.com";
            string to = "test2@test.com";
            string subject = "This is a test mail message";
            string body = "Hi test2";
            SmtpMail.Host = "192.168. 81. 100";
            SmtpMail.Port = 23;
            SmtpMail.Send(from, to, subject, body);
        }
    }
}
