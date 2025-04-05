class Customer
{
    private string _name;
    private Address _customerAddress;

    public Customer(string name, Address customerAddress)
    {
        _name = name;
        _customerAddress = customerAddress;
    }

    public void SetCustomerIsUSA()
    {
        _customerAddress.SetIsUSA();
    }

    public bool GetCustomerIsUSA()
    {

        return _customerAddress.GetIsUSA();
    }

    public void DisplayShipping()
    {
        Console.WriteLine($"\n{_name}\n_________________");
        _customerAddress.Display();
    }
}