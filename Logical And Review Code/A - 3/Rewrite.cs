class Laptop
{
    private string _os; // private member

    public Laptop(string os)
    {
        _os = os;
    }

    public string GetOs() // public method to access the Os property
    {
        return _os;
    }
}

var laptop = new Laptop("macOs");
Console.WriteLine(laptop.GetOs()); // Output: macOs
