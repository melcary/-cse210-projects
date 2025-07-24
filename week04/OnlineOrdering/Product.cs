using System;
using System.Runtime.CompilerServices;
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public void SetProductId(string productId)
    {
        _productId = productId;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }
}