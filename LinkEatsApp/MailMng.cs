using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace LinkEatsApp
{


    public class MailMng
    {
        private static MailMng _instance;
        public static MailMng Instance => _instance ?? (_instance = new MailMng());

        private MailAddress fromAddress = new MailAddress("linkeats@outlook.fr", "LinkEats");
        private MailAddress toAddress = new MailAddress("antoine.legois@viacesi.fr", "Antoine LEGOIS");

        const string userLogin = "linkeats@outlook.fr";
        const string userPassword = "lickit8=D";
        const string destMail = "antoine.legois@viacesi.fr";

        const string subject = "WELCOME TO LINKEATS";
        const string body = "Thanks to create an account in the new beta service LinkEats\nWe hoppe you will find everythinks you search for";

        //private SmtpClient smtp;

        private MailMng()
        {
        }


        //public void SendMessageTo(string destMail,string dest)
        public void SendMessageTo()
        {
            Thread t = new Thread(() => SendMessage());
            t.Start();
        }


        private void SendMessage()
        {
            try
            {
                MailMessage message = new MailMessage("linkeats@outlook.fr", "antoine.legois@viacesi.fr");
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = false;
                message.From = fromAddress;

                SmtpClient smtpC = new SmtpClient("smtp.office365.com", 587);
                smtpC.Credentials = new NetworkCredential("linkeats@outlook.fr", "lickit8=D");
                smtpC.Timeout = 60000;
                smtpC.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpC.EnableSsl = true;

                smtpC.Send(message);

                MessageBox.Show("Mail send succesful !");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : send email wasn't successful");
            }
        }




    }
}





