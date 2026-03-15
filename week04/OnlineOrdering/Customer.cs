using System;
using System.Net.Sockets;

public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name,Address adress)
    {
        _name = name;
        _address = address;
    }
    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }

    public GetShippingLabel()
    {
        return  $"{_name}\n{_address.GetFullAddress()}";
    }
}


    
    






