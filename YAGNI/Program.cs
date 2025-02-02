using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace YAGNI

{
    public class ProductService
    {
        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Producto {name} agragado, precio: {price}.");
        }

        public void DeleteProduct(string name)
        {
            Console.WriteLine($"Producto {name} eliminado.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();

            Console.WriteLine("Selecciona una opción: ");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            string? option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine("Ingresa el nombre del producto: ");
                string? name = Console.ReadLine();
                Console.WriteLine("Ingresa el precio del producto: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                productService.AddProduct(name, price);
            }
            else if (option == "2")
            {
                Console.WriteLine("Desea eliminar el producto? (s/n)");
                string? respuesta = Convert.ToString(Console.ReadLine());
                if (respuesta == "s")
                {
                    Console.WriteLine("Ingresa el nombre del producto: ");
                    string? name = Console.ReadLine();
                    productService.DeleteProduct(name);
                }
                else
                {
                    Console.WriteLine("Operación cancelada.");
                }
            }


        }
    }
}
