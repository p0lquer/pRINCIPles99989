using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS


{
    public class Restaurant
    {
        public decimal CalcTotal(decimal[] precio, decimal? tipPercentage)
        {
            decimal total = precio.Sum();
            _ = (tipPercentage.HasValue) ? total += total * (tipPercentage.Value / 100) : total = total * 100 / 10;
            return total;
        }
    }



    public class PruabaKiss
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            decimal[] precio = new decimal[3];
            decimal? tipPercentage = 100 / 10;
            Console.WriteLine("Ingresa los precios: ");

            string input = Console.ReadLine();

            string[] inputArray = input.Split(',');

            Console.WriteLine("Desea agregar propina personalizada? (s/n)");
            string respuesta = Convert.ToString(Console.ReadLine());

            if (respuesta == "s")
            {
                Console.WriteLine("Ingresa el porciento de propina: ");

                tipPercentage = Convert.ToDecimal(Console.ReadLine());

                for (int i = 0; i < inputArray.Length; i++)
                {
                    precio[i] = Convert.ToDecimal(inputArray[i]);
                }

                Console.WriteLine("The total price is: " + restaurant.CalcTotal(precio, tipPercentage));
            }
            else
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    precio[i] = Convert.ToDecimal(inputArray[i]);
                }
                Console.WriteLine("The total price is: " + restaurant.CalcTotal(precio, tipPercentage));
            }
        }
    }

}