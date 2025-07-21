class Product
{
    private string _name;

    private int _productId;

    private int _pricePerUnit;

    private int _quantity;

    public Product(string name, int Id, int price, int quantity)
    {
        _name = name;
        _productId = Id;
        _pricePerUnit = price;
        _quantity = quantity;

    }
    public string displayProductWithTotal()
    {
        return $"{_name} Id:{_productId} Cost Per Unit:{_pricePerUnit} Quantity ordered: {_quantity} Total cost: {(_pricePerUnit * _quantity)}";

    }
    public int returnCost()
    {
        return _pricePerUnit * _quantity;
    }


}