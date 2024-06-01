using System;

public class Product
{
    private string _name; // Private field for the product name
    private string _productID; // Private field for the product ID
    private double _price; // Private field for the product price
    private int _quantity; // Private field for the product quantity

    // Constructor to initialize the product with name, product ID, price, and quantity
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate the total price of the product based on its quantity
    public double CalculatePrice()
    {
        return _price * _quantity;
    }

    // Method to get the product name
    public string GetName()
    {
        return _name;
    }

    // Method to get the product ID
    public string GetProductID()
    {
        return _productID;
    }

    // Method to get the product price
    public double GetPrice()
    {
        return _price;
    }

    // Method to get the product quantity
    public int GetQuantity()
    {
        return _quantity;
    }
}
