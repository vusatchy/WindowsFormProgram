using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;
using System.Net;
using System.Net.Mail;

namespace BuisenessLayer
{
    class PasswordReset
    {
        private UserService service = new UserService();
        private const int LENGTH = 10;

        //private int port = 465;
        private int port = 587;

        private const String mail="registereduserservicebot@gmail.com";

        private const String password = "zcblpmpouvroqbff";

        private SmtpClient client;
        private MailMessage msg;
            



        public bool resetPasswordViaEmail(String email)
        {
            bool exist = service.getAll().Exists(x => x.email.Equals(email));
            if (exist == false)
            {
                return false;
            }

            User user = service.getAll().FirstOrDefault(x=>x.email.Equals(email));
            String password=generatPassword(LENGTH);
            user.password = getHasedPassword(password);
            service.update(user);
            sendEmail(email,password);
            return true;

        }

        private String getHasedPassword(String password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        private void sendEmail(String email,String passwordToSend)
        {
            client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;
            client.Timeout = 20000;
            client.Port = port;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(mail, password);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            msg = new MailMessage();
            msg.To.Add(new MailAddress(email));
            msg.From = new MailAddress(mail);
            msg.Subject = "Password recovering";
            msg.Body = "Your new password:" + passwordToSend;
            client.Send(msg);
        }

        private string generatPassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
