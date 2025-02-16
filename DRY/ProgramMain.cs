

namespace DRY
{
    internal class ProgramMain
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Paytoroll paytoroll = new Paytoroll();
                Console.WriteLine("Ingresa 1 para calcular el salario mensual o 2 para calcular el salario por hora: ");
                string option1 = Console.ReadLine();
                if (option1 == "1")
                {
                    Console.WriteLine("Ingresa el salario base: ");
                    decimal baseSalary = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("El salario total es: " + paytoroll.CalcPay(baseSalary));
                }
                else if (option1 == "2")
                {
                    Console.WriteLine("Ingresa las horas trabajadas: ");
                    decimal hoursWorked = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ingresa el salario por hora: ");
                    decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("El salario total es: " + paytoroll.CalcPayHour(hoursWorked, hourlyRate));
                }


            }
        }
    }
}
