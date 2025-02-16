
namespace KISS
{
    public class KissMain
    {
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
}
