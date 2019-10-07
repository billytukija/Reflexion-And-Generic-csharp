using System;
using System.Reflection;

namespace Reflexion_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sale = new Sale {
                SaleId = 1,
                Description = "Black Beans with 5% off",
                CreatedBy = 1,
                CreatedOn = DateTime.Now,
                ModifyBy = null,
                ModifyOn = null
            };

            var Product = new Product
            {
                ProductId = 1,
                Description = "Fufu",
                CreatedBy = 1,
                CreatedOn = DateTime.Now,
                ModifyBy = null,
                ModifyOn = null
            };

            Console.WriteLine("------------Sale--------------");
            ReflexionGeneric(Sale);

            Console.WriteLine("------------Product--------------");
            ReflexionGeneric(Product);
        }

        public static void ReflexionGeneric<T>(T Object)
        {
            var properties = Object.GetType().GetProperties();

            foreach (var prop in properties)
                Console.WriteLine($"{prop.Name} : {prop.GetValue(Object, null)}");
        }
    }
}
