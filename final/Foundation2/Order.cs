class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _orderCustomer;
    private double _subtotalCost;
    private double _totalCost;
    private double _shipping;

    public Order(Customer orderCustomer)
    {
        _orderCustomer = orderCustomer;
        _subtotalCost = 0;
        _shipping = 0;
        _totalCost = 0;
    }

    public void SetShipping(double shipping)
    {
        _shipping = shipping;
    }

    public void SetTotalCost(double totalCost)
    {
        _totalCost = totalCost;
    }

    public void CalcTotalCost()
    {
        _totalCost = _subtotalCost + _shipping;
    }

    public void SetSubtotalCost(double subtotalCost)
    {
        _subtotalCost = subtotalCost;
    }

    public void AddToSubtotalCost(double cost)
    {
        _subtotalCost += cost;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void CalcAllCosts()
    {
        SetSubtotalCost(0);
        foreach (Product product in _products)
        {
            product.CalcCost();
            AddToSubtotalCost(product.GetCost());
            product.DisplayCost();
        }
        _orderCustomer.SetCustomerIsUSA();
        if (_orderCustomer.GetCustomerIsUSA() == true)
        {
            SetShipping(5);
            CalcTotalCost();
        }

        else
        {
            SetShipping(35);
            CalcTotalCost();
        }
        Console.WriteLine($"\nSubtotal: ${_subtotalCost}\nShipping: ${_shipping}\nTotal: ${_totalCost}\n");
    }

    public void CreatePackingLabel()
    {
        foreach (Product product in _products)
        {
            product.DisplayPacking();
        }
    }

    public void CreateShippingLabel()
    {
        _orderCustomer.DisplayShipping();
    }
}