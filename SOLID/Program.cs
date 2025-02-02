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
            Console.WriteLine($"Notification logged: {message}");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {

        NotificationServices notificationServices = new NotificationServices();
        NotificationSMS notificationSMS = new NotificationSMS();
        NotificationLogger notificationLogger = new NotificationLogger();
        Console.WriteLine("Seleccione el tipo de notificación: ");
        Console.WriteLine("1. Email");
        Console.WriteLine("2. SMS");
        string option = Console.ReadLine();
        Console.WriteLine("Ingrese el mensaje: ");
        string message = Console.ReadLine();
        if (option == "1")
        {
            Console.WriteLine("Ingrese el correo electrónico: ");
            string email = Console.ReadLine();
            notificationServices.SendEmail(email, message);
            notificationLogger.LogNotification(message);
            Console.WriteLine("Mensaje enviado");
        }
        else if (option == "2")
        {
            Console.WriteLine("Ingrese el número de teléfono: ");
            string phoneNumber = Console.ReadLine();
            notificationSMS.SendSMS(phoneNumber, message);
            notificationLogger.LogNotification(message);
            Console.WriteLine("Mensaje registrado");
        }
    }
}


