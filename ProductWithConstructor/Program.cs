using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProductWithConstructor
{
    //            Create a new Visual Studio Console Application named ProductWithConstructor.Create a Product class that satisifies the following requirements:

    //You should not be able to create a product without providing a value for the Name, Price, and UnitsInStock properties.
    //You should be able to create a product without specifying a product Description.
    //You should be able to modify the Name, Price, and UnitsInStock properties after the product is created.

    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int UnitsInStock { get; set; }
            public string Description { get; set; }

            public Product (string name, double price, int unitsInStock, string description = "")
            {
                this.Name = name;
                this.Price = price;
                this.UnitsInStock = unitsInStock;
                this.Description = description;

            }

            //static public void CreateProduct()
            //{
            //    Console.WriteLine("Enter product name: ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter price: ");
            //    double price = Double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter units in stock: ");
            //    int units = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter description: ");
            //    string description = Console.ReadLine();
                
            //    var hairGel = new Product("Hair Gel", 5, 100);
            //}

            
        }



        static void Main(string[] args)
        {
            var hairGel = new Product("Hair Gel", 5, 100);

            var name = hairGel.Name;
            var price = hairGel.Price;
            var units = hairGel.UnitsInStock;
            var description = hairGel.Description;
            var output = String.Format("Product Name: {0}\n Price: {1}\n Units In Stock: {2}\n Description: {3} \n", name, price, units, description);

            Console.WriteLine(output);

            hairGel.Name = "Super Duper Gel";
            hairGel.Price = 10;
            hairGel.UnitsInStock = 200;
            hairGel.Description = "Super hold gel";
            name = hairGel.Name;
            price = hairGel.Price;
            units = hairGel.UnitsInStock;
            description = hairGel.Description;

            output = String.Format("Product Name: {0}\n Price: {1}\n Units In Stock: {2}\n Description: {3} \n ", name, price, units, description);
            Console.WriteLine(output);
            Console.ReadLine();        
                  

        }
    }
}
