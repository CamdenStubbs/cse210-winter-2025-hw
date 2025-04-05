class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;
    private double _cost;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double GetCost()
    {
        return _cost;
    }

    public void DisplayPacking()
    {
        Console.WriteLine($"{_name}: {_productId}");
    }

    public void CalcCost()
    {
        _cost = _pricePerUnit * _quantity;
    }
    public void DisplayCost()
    {
        Console.WriteLine($"{_quantity} of {_name}: ${_cost}");
    }
}