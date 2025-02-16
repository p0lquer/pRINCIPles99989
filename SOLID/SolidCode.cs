using System;

using SOLID;

namespace SOLID
{
    public class NotificationServices
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Email enviado a  {email} con el mensaje: {message}");
        }
    }


    public class NotificationSMS
    {
        public void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"SMS enviado a {phoneNumber} con el mensaje: {message}");
        }
    }


    public class NotificationLogger
    {
        public void LogNotification(string message)
        {
            Console.WriteLine($"Notificacion logeada: {message}");
        }
    }
}




