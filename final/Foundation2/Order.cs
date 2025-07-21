using System.Reflection.Emit;

class Order
{
    List<Product> _Products = new List<Product>();

    private Customer _customer;

    private int _totalPrice = 0;

    public Order(string name, string street, string city, string state, string country)
    {
        Customer newCustomer = new Customer(name, street, city, state, country);
        _customer = newCustomer;
    }

    public void addProduct(string name, int ID, int price, int quantity)
    {
        Product newProduct = new Product(name, ID, price, quantity);
        _Products.Add(newProduct);
    }
    private void GetTotalPrice()
    {
        foreach (Product product in _Products)
        {
            _totalPrice = _totalPrice + product.returnCost();
        }
        if (USA())
        {
            _totalPrice = _totalPrice + 5;
        }
        else
        {
            _totalPrice = _totalPrice + 35;
        }
    }
    private bool USA()
    {
        return _customer.USA();
    }
    public void PackingLabel()
    {
        Console.WriteLine($"{_customer.GetName} \n  {_customer.returnAddress}");
    }
    public void ShipingLabel()
    {
        GetTotalPrice();
        Console.WriteLine($"{_customer.GetName} total cost: {_totalPrice}");
        foreach (Product product in _Products)
        {
            Console.WriteLine($"{product.displayProductWithTotal}");
        }
        Console.WriteLine($"total cost: {_totalPrice}");
    }
    public void printTotalPrice()
    {
        Console.WriteLine($"Total Price: {_totalPrice}");
    }

}