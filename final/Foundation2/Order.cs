using System.Net.Http.Headers;

public class Order
{
    private Customer Customer = new Customer();
    private List<Product> _products = new List<Product>();

    public Order()
    {
    }

    public void AddProducts(Product product)
    {
        _products.Add(product);
    }
    public void SetCustomer(Customer newcustomer)
    {
        Customer = newcustomer;
    }

    public float GetCost()
    {
        bool _country = Customer.CheckAddress();
        float _cost = 0;
        List<float> _costList = new List<float>();

        foreach (Product product in _products)
        {
            _costList.Add(product.ProductCost());
        }

        for (int i = 0; i < _costList.Count(); i++)
        {
            _cost += _costList[i];
        }
        

        if (_country == true)
        {
            _cost += + 5;
        }
        else
        {
            _cost += 35;
        }

        return _cost; 
        
        
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("************************************************");
        Console.WriteLine("Packing Label");
        foreach (Product product in _products)
        {
            string productName = product.GetProduct();
            Console.WriteLine();
            Console.WriteLine($"{productName}");
            Console.WriteLine();
        }
        Console.WriteLine("************************************************");
    }

    public void GetShippingLabel()
    {
        string name = Customer.GetCustomer();
        Address Address1 = Customer.GetAddress();
        string addressLabel = Address1.GetAddress();
        Console.WriteLine("************************************************");
        Console.WriteLine();
        Console.WriteLine("Ship to:");
        Console.WriteLine();
        Console.WriteLine($"{name}");
        Console.WriteLine($"{addressLabel}");
        Console.WriteLine();
        Console.WriteLine("************************************************");
    }


}