using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace LinkEatsApp
{


    public class MailMng
    {
        private static MailMng _instance;
        public static MailMng Instance => _instance ?? (_instance = new MailMng());

        private MailAddress fromAddress = new MailAddress("antoine.legois@viacesi.fr", "LinkEats");
        private MailAddress toAddress = new MailAddress("qalegois@gmail.com", "Antoine LEGOIS");
        const string fromPassword = "CESI_Legois!2022*";
        const string subject = "WELCOME TO LINKEATS";
        const string body = "Thanks to create an account in the new beta service LinkEats\nWe hoppe you will find everythinks you search for";

        private SmtpClient smtp;

        private MailMng()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromAddress.Address, fromPassword);


            //using (var message = new MailMessage(fromAddress, toAddress)
            //{
            //    Subject = subject,
            //    Body = body
            //})

            //{
            //    smtp.Send(message);
            //}
        }


        public void SendMessageTo(string destMail,string dest)
        {
            MailAddress destMAilAddress = new MailAddress(destMail, dest);
            MailMessage message = new MailMessage(fromAddress, destMAilAddress );
            message.Subject = subject;
            message.Body = body;

            smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential(fromAddress.Address, fromPassword);

            smtp.Send(message);
        }





    }
}





