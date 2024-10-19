class Address
{

    // This class stores a street address. It also stores the city,state, and country of the address. 
    private string _address = "";
    private string _stateProvince = "";
    private string _country = "";
    private string _city = "";

    // Set each part of the address when the constructor is called.
    public Address(string address, string city,string stateProvince,string country)
    {
        _address = address;
        _stateProvince = stateProvince;
        _country = country;
        _city = city;
    }

    // Get Address returns the address as a string in the form of street address, next line and tab, 
    //city, state or province, and finally country with spaces in between.
    public string GetAddress()
    {
        return _address + "\n\t" + _city + " " +  _stateProvince + " " +  _country;
    }
}