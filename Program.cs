// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//base Vehicle
Car anotherCar= new Car("Toyota Camry", 3, "white", "gas");

//create a Child Car instance
Car car= new Car("Nissan Altima", 4, "blue", "gas");

//create a Child Horse Instance
Horse horse= new Horse("Donna","brown", "hay");

// create a Child Bicycle Instance
Bicycle bicycle= new Bicycle("Specialized", "green");

List<Vehicle> AllVehicles= new List <Vehicle>();
AllVehicles.Add(anotherCar);
AllVehicles.Add(bicycle);
AllVehicles.Add(horse);
AllVehicles.Add(car);

foreach(Vehicle v in AllVehicles)
{
    v.ShowInfo();
}

car.Travel(100);
car.ShowInfo();

List<INeedFuel> FuelUsers= new List<INeedFuel>();
//loop through all vehicles and add those with INeedFuel to Fuel Users List
foreach (Vehicle v in AllVehicles)
{
    if (v is INeedFuel)
    {
        FuelUsers.Add((INeedFuel)v);
    }
}

//loop through and give 10 units of fuel
foreach (INeedFuel f in FuelUsers)
{
    f.GiveFuel(10);
    Console.WriteLine ($"Fuel Total: {f.FuelTotal}");
}