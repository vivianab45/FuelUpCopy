public class Vehicle
{
    ////fields
    public string Name;
    public int NumPassengers;
    public string Color;
    public bool HasEngine;
    public int Distance=0;
    ////constructor 1- fill in all fields except distance travelled
    public Vehicle(string n, int np, string c, bool he )
    {
        Name=n;
        NumPassengers= np;
        Color=c;
        HasEngine= he;
    }
    //// constructor 2- allow user to fill in all fields
    //provide default values for other fields
    public Vehicle(string n, string c)
    {
        Name=n;
        NumPassengers= 5;
        Color=c;
        HasEngine= true;
    }
    ////methods
    //method1- print out all the vehicle info
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"NumPassengers: {NumPassengers}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Has an Engine: {HasEngine}");
        Console.WriteLine($"Distance: {Distance}");
    }
    //method2-accept any input for distance;
    //adds that distance to the total and prints 
    //out a message showing how far the vehicle has gone
    public void Travel( int dist)
    {
        Distance+=dist;
        Console.WriteLine($"{Name} has now traveled {Distance}");
    }
}