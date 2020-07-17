using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            sendEmail();
        }

        public static void sendEmail()
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("varun.poosala595@gmail.com");
                message.To.Add(new MailAddress("varunkumar.poosala@ggktech.com"));
                message.Subject = "Sample mail";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "<html><body><h2>Welcome to my world</h2></body></html>";
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("varun.poosala595@gmail.com", "Ggku2sys24");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
            }
        }

    }
   }
