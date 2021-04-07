using System;
using System.Collections.Generic;
using System.Globalization;
using ConsoleApp1.Entities;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtd = int.Parse(Console.ReadLine());
            string name;
            double price;
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Product # {i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

              
                if (type == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactreDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactreDate));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double custmsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProcuct(name, price, custmsFee));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product obj in list)
            {
                Console.WriteLine(obj.PriceTag());
            }
        }
    }
}
