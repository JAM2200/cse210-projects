using System.Security.Cryptography;

class Product 
{

    // This class stores information about a produce including its name, id, price, and quantity ordered.
    private string _name;
    private int _id;
    private float _price = 0f;
    private int _quantity = 0;

    // Initialize the name, id, price, and quantity through the constructor.
    public Product(string name,int id,float price,int quantity)
    {
        _price = price;
        _name = name;
        _id = id;
        _quantity = quantity;
    }

    // Return the price of the product.
    public float GetPrice()
    {
        return _price;
    }

    // Get the total price of the quantity spedcified.
    public float PriceOfQuantity()
    {
        // Makes sure the quantity is greater than 0.  Just in case something was entered incorrectly.
        if(_quantity > 0)
            // If the quantity is grater than 0, return the price times the quantity.
            return _price * _quantity;
        else
            // If not return 0.
            return 0f;

    }

    // Add one to the quantity.
    public void Add()
    {
        _quantity++;
    }
    // Remove as many from the item as specified.
    public void Remove(int numberToRemove, bool removeAll)
    {
        // If removeAll is true then the quantity is set to 0. 
        if(removeAll)
            _quantity = 0;
        else
            // else the numberToRemve is subtracted from the quantity
            _quantity -= Math.Abs(numberToRemove);
        // Make sure the quantity is not fewer than 0.
        if(_quantity < 0)
            _quantity = 0;
    }


    // Returns a string in the form of name id: xxxx quantity: x unit price: x.xx.
    public string  ProductInfo()
    {
        return $"{_name} id: {PadID()} quantity: {_quantity} unit price: ${_price:0.00}\n";
    }


    // Returns an id as a string in the form of xxxx.
    // This is going to allow leading zeros for the id.  For example, 0023, instead of 23.  
    private string PadID()
    {

        // Create a variable to store the id as a string.
        string paddedID = "";
        // Copy the id value so that it is not affected.
        int idToPad = _id;
        
        // Start at a thousand and divide by ten until the it is less than or equal to 0.
        // Check to see if each column is 0 starting from the 1000's column.
        for(int i = 1000;i > 0; i /= 10)
        {   
            // Check to see if the copied id devided by ten is 0.
            if(idToPad / i == 0)
            {
                // If it is, add 0 to paddedID.
                paddedID = paddedID + "0";
            }else{
                // Else add IdToPad / i  to the paddedI.
                paddedID = paddedID + (idToPad / i).ToString();
            }
            // Subtract the curretn column being checked.  For example, if the id is 1234
            // then the equation would look like this in the first iteration of the loop,
            // 1234 - (1234 / 1000) * 1000. which becomes 1234 - (1) * 1000
            // then 1234 - 1000, and finally 234.   
            idToPad = idToPad - (idToPad / i) * i;

            
        }

        // Return the padded Id as a string.
        return paddedID;
    }
}