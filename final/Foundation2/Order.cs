public class Order
{
    private Product[] _products;
    private Customer _customer;

    public Order(Product[] products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        for (int i = 0; i < _products.Length; i++)
        {
            totalCost += _products[i].GetTotalCost();
        }
        totalCost += _customer.LivesInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        for (int i = 0; i < _products.Length; i++)
        {
            packingLabel += $"{_products[i].GetName()} (ID: {_products[i].GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
