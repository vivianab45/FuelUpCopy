public class Horse: Vehicle, INeedFuel
{
    public string FuelType {get;set;}
    public int FuelTotal {get;set;}
    //constructor
    public Horse (string n, string c, string ft) : base( n, 2, c, false )
    {
        FuelType= ft;
        FuelTotal= 10;
    }
    public void GiveFuel (int Amount)
    {
        FuelTotal +=Amount;
        Console.WriteLine ($"Fueled the {Name} with {FuelType} to {FuelTotal}");
    }
    //now we have to go to Program.CS and include fuel type
}