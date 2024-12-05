using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("2272 N 3875", "Ogden", "UT", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Jimmy John", address1);
        Customer customer2 = new Customer("Lafaunda Page", address2);

        Product product1 = new Product("Widget A", "A123", 10.0, 3);
        Product product2 = new Product("Widget B", "B456", 20.0, 2);
        Product product3 = new Product("Widget C", "C789", 15.0, 1);

        Product product4 = new Product("Gadget X", "X321", 50.0, 1);
        Product product5 = new Product("Gadget Y", "Y654", 30.0, 4);

        Product[] order1Products = { product1, product2, product3 };
        Product[] order2Products = { product4, product5 };

        Order order1 = new Order(order1Products, customer1);
        Order order2 = new Order(order2Products, customer2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}
