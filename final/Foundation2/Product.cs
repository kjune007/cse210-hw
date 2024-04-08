public class Product
{
    private string _productName;
    private string _productID;
    private float _pricePerUnit;
    private int _quantity;
    public Product()
    {
    }
    public void SetProduct(string product, string id, float price, int quantity)
    {
        _productName = product;
        _productID = id;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public float ProductCost()
    {
        float price = _pricePerUnit * _quantity;
        return price;
    }

    public string GetProduct()
    {
        return $"Product: {_productName}\nProduct ID #{_productID}\nQuantity: {_quantity}";
    }

}