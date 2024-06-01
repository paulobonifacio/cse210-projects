using System;

public class Address
{
    private string _street; // Private field for street
    private string _city;   // Private field for city
    private string _state;  // Private field for state
    private string _country; // Private field for country

    // Constructor to initialize the address with street, city, state, and country
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Method to check if the country is USA
    public bool isUSA()
    {
        return _country == "USA" ? true : false;
    }

    // Method to generate a formatted address string
    public string GenerateAddress()
    {
        string address = _street + ", " + _city + "\n" + _state + ", " + _country;
        return address;
    }
}
