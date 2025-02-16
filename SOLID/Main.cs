

namespace SOLID
{
    internal class Main
    {
        public class SolidCode
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
    }
}
