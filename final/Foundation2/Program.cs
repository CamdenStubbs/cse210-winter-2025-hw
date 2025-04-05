using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nORDER 1:");
        Address address1 = new Address("355 New Venue Ave.", "New York City", "New York", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        Product firstProduct1 = new Product("Dove Deodorant", "12382930461239", 9.79, 2);
        Product secondProduct1 = new Product("Baked Lays", "73610249360267", 4.79, 5);
        order1.AddProduct(firstProduct1);
        order1.AddProduct(secondProduct1);
        order1.CreateShippingLabel();
        order1.CreatePackingLabel();
        Console.WriteLine();
        order1.CalcAllCosts();

        Console.WriteLine("\nORDER 2:");
        Address address2 = new Address("666 Nowhere Ave.", "Psuedoplace", "False Town", "Fakegium");
        Customer customer2 = new Customer("Jane Wane", address2);
        Order order2 = new Order(customer2);
        Product firstProduct2 = new Product("Tomatoes", "63248301042834", 1.79, 3);
        Product secondProduct2 = new Product("The Best Board Game", "43098147263890", 51.99, 1);
        Product thirdProduct2 = new Product("Headphones", "2147012782563012", 29.99, 2);
        order2.AddProduct(firstProduct2);
        order2.AddProduct(secondProduct2);
        order2.AddProduct(thirdProduct2);
        order2.CreateShippingLabel();
        order2.CreatePackingLabel();
        Console.WriteLine();
        order2.CalcAllCosts();
    }
}