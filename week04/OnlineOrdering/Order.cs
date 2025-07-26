public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotal();
        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string message()
    {
        if (_customer.LivesInUSA())
        {
            return "For customers living in the USA, $5 is added to the total purchase.";
        }
        else
        {
            return "For customers living outside the USA, $30 is added to the total purchase.";
        }
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetID()}) (Price: {product.GetTotal()}$)\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {   
        return $"Shipping Label:\n  {_customer.GetName()}\n{_customer.GetFullAddress()}";
    }
}