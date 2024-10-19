using System.Security.Cryptography.X509Certificates;

class Order
{

    // Order stores the information relevant to an order online.

    // Store a list of products on the order.
    private List<Product> _products = new List<Product>();

    // Instantiate a customer object;
    private Customer _customer;

    // Add an item to the order.  Enter the id, unit price, and quantity of the item. 
    public void AddToCart(string name,int id,float price,int quantity)
    {
        // Initialize a product it through its constructor.
        Product newProduct = new Product(name,id,price,quantity);
        // Add the new product to the product lists.  
        _products.Add(newProduct);
    }   

    // Add information about the customer to the order.
    public void AddCustomerInfo(string address, string city,string stateProvince,string country,string name)
    {
        // Initialize the customer with the street address, city, state or privince, country, and name through the constructor. 
        _customer = new Customer(address,city,stateProvince,country,name);
    }

    //  Create a packing lable and return it as a string.
    public string PackingLabel()
    {
        // Create a variable to store the label.
        string receipt = "";
        // Create a variable to store the total of the order.
        float total = 0f;

        // Iterate through each product and add it to the label.
        foreach(Product product in _products)
        {
            // Add the product information to the receipt through the Product.ProductInfo() method.
            receipt = receipt +  product.ProductInfo();
            // Use the Product.PriceOfQuantity() method to 
            // get the total price of the quantity and add it to the total.
            total += product.PriceOfQuantity();
        }
        
        // Create a variable to store the price of shipping.  Initialize it to $35 and assume the address is 
        // not in the United States.
        float shippingPrice = 35f;

        //  Check if the address is in the United States and change the shipping price to $5 if it is. 
        if(_customer.CountryIsUSA())
        {
            shippingPrice = 5f;
        }
        // Add the shipping price to the total.
        total += shippingPrice;

        /* Return a string in the following format:
            Shipping: $x.xx
            Total: $x.xx    
        */

        return receipt + $"\nShipping: ${(float)Math.Round(shippingPrice,2):0.00}\n" + "Total: $" + $"{(float)Math.Round(total,2):0.00}";
    }

    // Returns a string with the address information and the name of the customer.
    public string  ShippingLabel()
    {
        // Get the address via the GetAddressAndName() method.
        return  "Ship To:\n\t" + _customer.GetAddressAndName();  
    }

}