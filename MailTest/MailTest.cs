using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mail;

namespace MailTest
{
    class MailTest
    {
        static void Main(string[] args)
        {
            string from = "test1@test.com";
            string to = " test2@test.com ";
            string subject = "This is a test mail message";
            string body = "Hi test2";
            SmtpMail.SmtpServer = "192.168.81.100";
            SmtpMail.Send(from, to, subject, body);
        }
    }
}
