using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Creating first order

        Customer Customer1 = new Customer();
        Address Address1 = new Address();
        Order Order1 = new Order();
        Product Product1 = new Product();
        Product Product2 = new Product();
        Product Product3 = new Product();

        string customerName = "John Smith";
        string street = "1100 W Random Street";
        string city = "Rexburg";
        string state = "Idaho";
        string country = "USA";
        Address1.SetAddress(street,city,state,country);
        Customer1.SetCustomer(customerName,Address1);

        string _product1Name = "Premium Office Pens";
        string _product1ID = "1127A1322D";
        float _pricePerUnit = 12.99F;
        int _quantity =  3;

        string _product2Name = "Premium office paper";
        string _product2ID = "1325B3321B";
        float _pricePerUnit2 = 5.95F;
        int _quantity2 = 2; 

        string _product3Name = "Premium Staplers";
        string _product3ID = "1324C5645H";
        float _pricePerUnit3 = 21.55F;
        int _quantity3 = 1;

        Product1.SetProduct(_product1Name,_product1ID,_pricePerUnit,_quantity);
        Product2.SetProduct(_product2Name,_product2ID,_pricePerUnit2,_quantity2);
        Product3.SetProduct(_product3Name,_product3ID,_pricePerUnit3,_quantity3);

        Order1.SetCustomer(Customer1);
        Order1.AddProducts(Product1);
        Order1.AddProducts(Product2);
        Order1.AddProducts(Product3);

        Order1.GetPackingLabel();
        Thread.Sleep(1000);
        Console.WriteLine();
        Order1.GetShippingLabel();
        Thread.Sleep(1000);
        Console.WriteLine();
        float price = Order1.GetCost();
        Console.WriteLine($"Total billing price: ${price}");
        Console.WriteLine();
        Console.WriteLine();


        //Creating Second Order
        Customer Customer2 = new Customer();
        Address Address2 = new Address();
        Order Order2 = new Order();
        Product Product21 = new Product();
        Product Product22 = new Product();
        Product Product23 = new Product();

        string customer2Name = "William Nelson";
        string street2 = "2200 N Specific Street";
        string city2 = "Calary";
        string state2 = "Alberta";
        string country2 = "Canada";
        Address2.SetAddress(street2,city2,state2,country2);
        Customer2.SetCustomer(customer2Name,Address2);

        string _product21Name = "Premium Winter Coat";
        string _product21ID = "1127B1322E";
        float _pricePerUnit21 = 112.99F;
        int _quantity21 =  1;

        string _product22Name = "Premium Winter Gloves";
        string _product22ID = "1325C3321D";
        float _pricePerUnit22 = 55.95F;
        int _quantity22 = 2; 

        string _product23Name = "Premium Winter Hats";
        string _product23ID = "1324D5645I";
        float _pricePerUnit23 = 22.59F;
        int _quantity23 = 2;

        Product21.SetProduct(_product21Name,_product21ID,_pricePerUnit21,_quantity21);
        Product22.SetProduct(_product22Name,_product22ID,_pricePerUnit22,_quantity22);
        Product23.SetProduct(_product23Name,_product23ID,_pricePerUnit23,_quantity23);

        Order2.SetCustomer(Customer2);
        Order2.AddProducts(Product21);
        Order2.AddProducts(Product22);
        Order2.AddProducts(Product23);

        Order2.GetPackingLabel();
        Thread.Sleep(1000);
        Console.WriteLine();
        Order2.GetShippingLabel();
        Thread.Sleep(1000);
        Console.WriteLine();
        float price2 = Order2.GetCost();
        Console.WriteLine($"Total billing price: ${price2}");
        Console.WriteLine();
    }
}