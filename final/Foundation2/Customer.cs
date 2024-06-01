using System;

public class Customer
{
    private string _name; // Private field for the customer's name
    private Address _address; // Private field for the customer's address

    // Constructor to initialize the customer with a name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer's address is in the USA
    public bool isFromUSA()
    {
        return _address.isUSA() ? true : false;
    }

    // Method to get the customer's name
    public string GetName()
    {
        return _name;
    }

    // Method to generate the customer's address as a formatted string
    public string GenerateAddress()
    {
        string generatedAddress = _address.GenerateAddress();
        return generatedAddress;
    }
}