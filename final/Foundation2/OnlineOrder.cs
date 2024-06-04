using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products; // Private field for the list of products
    private Customer _customer; // Private field for the customer

    // Constructor to initialize the order with a list of products and a customer
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Method to calculate the shipping cost based on the customer's location
    public double CalculateShipping() 
    {
        double shippingCost = _customer.isFromUSA() ? 5 : 35;
        return shippingCost;
    }

    // Method to calculate the total price of the order including shipping
    public double CalculateTotalPrice()
    {
        double totalprice = 0;

        // Loop through each product to calculate the total price of products
        foreach (Product p in _products) 
        {
            double price = p.CalculatePrice();
            totalprice += price;
        }

        double shippingCost = CalculateShipping(); // Calculate shipping cost
        totalprice += shippingCost; // Add shipping cost to the total price
        return totalprice;
    }

    // Method to generate a packing label for the order
    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        // Loop through each product to add its name and ID to the packing label
        foreach (Product p in _products) 
        {
            packingLabel += p.GetName() + " - " + p.GetProductID() + "\n";
        }
        return packingLabel;
    }

    // Method to generate a shipping label for the order
    public string GenerateShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += _customer.GetName() + "\n" + _customer.GenerateAddress();
        return shippingLabel;
    }

    // Method to generate a detailed total cost breakdown for the order
    public string GenerateTotalCost()
    {
        string totalCost = "\nProducts:\n";
        double totalPrice = CalculateTotalPrice();
        // Loop through each product to add its details to the total cost breakdown
        foreach (Product p in _products) 
        {
            totalCost += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalculatePrice() + "\n";
        }
        
        totalCost += "Shipping Cost: $" + CalculateShipping() + "\n";
        totalCost += "Total: $" + CalculateTotalPrice();
        
        return totalCost;
    }

    // Method to display the results including packing label, shipping label, and total cost
    public void DisplayResults()
    {
        string packingLabel = GeneratePackingLabel();
        string shippingLabel = GenerateShippingLabel();
        string totalCost = GenerateTotalCost();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalCost);
    }
}
