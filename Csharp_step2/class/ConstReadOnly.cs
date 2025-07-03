class ConstReadOnlyExample
{
    // Constant fields (must be assigned at declaration)
    const double Pi = 3.141598765555;   // Compile-time constant
    const string companyName = "TCS";

    // Readonly fields (can be assigned at declaration or in constructor)
    readonly string createdDate = "Jan-01-2025";
    readonly double length;

    public ConstReadOnlyExample()
    {
        createdDate = "Dec-01-2025";
    }

    public void Method1()
    {
        // You cannot change const or readonly fields here.
    }

    static void Main()
    {
        ConstReadOnlyExample example = new ConstReadOnlyExample();
    }
}