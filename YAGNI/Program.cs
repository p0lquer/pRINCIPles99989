

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
    
}
