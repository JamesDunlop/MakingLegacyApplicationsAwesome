﻿using System.Net.Mail;
using MLAA.Data.Linq2Sql.EventHandlers.WhenAStudentEnrolsInASubject;

namespace MLAA.Web
{
    public class SmtpEmailSender : IEmailSender
    {
        public void Send(MailMessage message)
        {
            var client = new SmtpClient("localhost");
            client.Send(message);
        }
    }
}