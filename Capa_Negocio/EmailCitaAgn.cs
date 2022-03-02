using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Capa_Negocio
{
    public class EmailCitaAgn
    {
        MailMessage ml = new MailMessage();
        SmtpClient smtp = new SmtpClient();


        public bool enviarcorreo(string from, string pass, string to, string mensaje)
        {
            //string fechaAct = DateTime.Now.ToLongDateString();
            string fechaAct = DateTime.Now.ToShortDateString();

            try
            {
                ml.From = new MailAddress(from, "SP AGENDAMIENTO CITAS", System.Text.Encoding.UTF8);
                ml.To.Add(new MailAddress(to));

                ml.Body = mensaje;
                ml.Subject = "CITA AGENDADA - " + fechaAct;
                smtp.Host = "smtp.gmail.com";

                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.EnableSsl = true;

                smtp.Send(ml);
                ml.IsBodyHtml = true;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }
    }
}
