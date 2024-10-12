class Customer
{
    // Customer stores information about a customer in the program.

    // It stores an address and the customer's name.
    public string _name;
    public Address _address;
    
    
    // Initialize the variables when the constructor is called.
    public Customer(string address, string city,string stateProvince,string country,string name) 
    // => (address,city,stateProvince,country,name) = (address,city,stateProvince,country,name); 
    {
        // Set the name and address through the Address constructor.
        _name = name;
        _address = new Address(address,city,stateProvince,country);
    }

    // Returns true if the address is in the United States, or false it is somewhere else.
    public bool CountryIsUSA()
    {
        // Check to see if the address contains "united states," "us," or "usa," by using the Address.GetAddress() method 
        // and then converting the string to lowercase. 
        if(_address.GetAddress().ToLower().Contains("united states") || _address.GetAddress().ToLower().Contains("us") ||  _address.GetAddress().ToLower().Contains("usa") )
        {
            // Return if the address is in the United States;
            return true;
        }else
        {   
            // Return false if the country is outside of the United States.
            return false;
        }
    }

    // Returns a the name and the address using the Address.GetAddress() method.
    public string GetAddressAndName()
    {
        return _name + "\n\t" + _address.GetAddress();
    }
}