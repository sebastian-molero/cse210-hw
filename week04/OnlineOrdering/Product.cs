public class Product
{
    private string _pName;
    private int _pID;
    private double _price;
    private int _quantity;

    public Product(string pName, int pID, double price, int quantity)
    {
        _pName = pName;
        _pID = pID;
        _price = price;
        _quantity = quantity;
    }

    public Product(string pName, int pID, double price)
    {
        _pName = pName;
        _pID = pID;
        _price = price;
        _quantity = 1;
    }

    public double GetTotal()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _pName;
    }

    public int GetID()
    {
        return _pID;
    }
}