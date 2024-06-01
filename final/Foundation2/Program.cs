using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating Order 1
        Address address1 = new Address("Parvis 525", "Saint Roch", "Quebec", "Canada");
        Customer customer1 = new Customer("Guilleme Trudeau", address1);
        List<Product> productsList1 = new List<Product>();

        // Adding products to Order 1
        Product p1001 = new Product("NVIDIA 10300", "GC200", 1.379, 1);
        Product p1002 = new Product("Laptop Gamer", "XTZ", 7.599, 1);
        Product p1003 = new Product("Mouse Pro Gamer", "XSRS",  59.99, 10);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        // Creating Order object for Order 1
        Order order1 = new Order(productsList1, customer1);

        // Displaying results for Order 1
        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Creating Order 2
        Address address2 = new Address("Savoise 8", "Geneva", "1205", "Suisse");
        Customer customer2 = new Customer("Fatima Micharia", address2);
        List<Product> productsList2 = new List<Product>();

        // Adding products to Order 2
        Product p2001 = new Product("Sanfona Pro Music", "XLTS", 3.999, 1);
        Product p2002 = new Product("Iphone Pro Max 15", "PRO", 1.599, 1);
        Product p2003 = new Product("Chole Bag", "CHLB", 77.99, 1);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        // Creating Order object for Order 2
        Order order2 = new Order(productsList2, customer2);

        // Displaying results for Order 2
        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Creating Order 3
        Address address3 = new Address("AV Paulista", "SP", "08897-033", "Brazil");
        Customer customer3 = new Customer("Kevin Cleitin", address3);
        List<Product> productsList3 = new List<Product>();

        // Adding products to Order 3
        Product p3001 = new Product("Meta VR", "MTPRO", 3000, 1);
        Product p3002 = new Product("Ipado Pro", "IPPRO", 2000, 1);
        Product p3003 = new Product("ASUS Pro Gamer", "ASUSP", 5000, 1);

        productsList3.Add(p3001);
        productsList3.Add(p3002);
        productsList3.Add(p3003);

        // Creating Order object for Order 3
        Order order3 = new Order(productsList3, customer3);

        // Displaying results for Order 3
        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}