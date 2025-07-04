
class ConstReadOnlyExample
{

    //const double pi;
    const double Pi = 3.141598765555;   //0 marks
    //Compile time constant

    const string compnayName = "Misard";

    readonly string createdDate = "Mar-01-2025";

    readonly double length;


    public ConstReadOnlyExample()
    {
        //this.Pi = Pi * Pi;
        //compnayName = "TCS";
        createdDate = "Oct-01-2025";
    }


    public void Method1()
    {

        //this.Pi = 10.09;
    }

    static void Main()
    {
        ConstReadOnlyExample example = new ConstReadOnlyExample();



     
    }




}