using System.Dynamic;

class Program
{
    static void Main()
    {

        // Instatiate an order to contain the items purchased and address customer.
        Order order1 = new Order();

        // Add three items to the order using the Order.AddToCart() Method;
        order1.AddToCart("T Shirt",1243,10.99f,2);
        order1.AddToCart("Jeans",1244,10.86f,2);
        order1.AddToCart("Leather Wallet",1245,28.63f,2);

        // Add the address to the order.  It contains the road, city, state or province, country, and the name of the customer.
        // The address is in the United States.
        order1.AddCustomerInfo("110 Maple Rd.","Flatsville","New York","USA","John Doe");

        //Make a shipping label and a packing label, and store them in strings.
        string shippingLabel1 = order1.ShippingLabel();
        string packingLabel1 = order1.PackingLabel();

        // Print out 
        Console.WriteLine($"Shipping Label:\n{shippingLabel1}\n\nPacking Label:\n{packingLabel1}\n");

        // Same as the order1 but with different items for a different customer with a different address.  Also lives in the United States.
        Order order2 = new Order();

        order2.AddToCart("Baseball Caps",1234,5.25f,40);
        order2.AddToCart("Baseball Mits",0001,35.67f,20);
        order2.AddToCart("Baseball Bats",0002,59.99f,20);

        order2.AddCustomerInfo("1600 Pennslyvania Ave.","New York City","New York","United States","Roger Rabbit");

        string shippingLabel2 = order2.ShippingLabel();


        string packingLabel2 = order2.PackingLabel();

        Console.WriteLine($"Shipping Label:\n{shippingLabel2}\n\nPacking Label:\n{packingLabel2}\n");

        
        // Same as the order1 and order2, but the address is outside the United states.
        Order order3 = new Order();

        order3.AddToCart("Mountain Bike",1001,867.99f,1);
        order3.AddToCart("Bike Helmet",1002,156.19f,1);
        order3.AddToCart("Tubless Tires",1003,35.49f,4);

        order3.AddCustomerInfo("42 Carrington Ln.","Yellowknife","Northwest Territories","Canada","Atticus Finch");

        string shippingLabel3 = order3.ShippingLabel();
        string packingLabel3 = order3.PackingLabel();

        Console.WriteLine($"Shipping Label:\n{shippingLabel3}\n\nPacking Label:\n{packingLabel3}\n");

    }


}