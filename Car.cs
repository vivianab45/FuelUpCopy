public class Car: Vehicle, INeedFuel
{
    public string FuelType {get;set;}
    public int FuelTotal {get;set;}
    //constructor
    public Car (string n, int np, string c, string ft) : base( n, np, c, true )
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