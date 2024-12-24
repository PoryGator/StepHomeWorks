using System;
using System.Collections.Generic;

public enum FuelType
{
    Petrol,
    Diesel,
    Electric
}

public enum BodyType
{
    Sedan,
    Hatchback,
    SUV,
    Bus
}


public class Transport
{
    public string Make { get; set; }  
    public string Model { get; set; }  
    public int Year { get; set; } 
    public FuelType Fuel { get; set; }
    public BodyType Body { get; set; } 

    public Transport(string make, string model, int year, FuelType fuel, BodyType body)
    {
        Make = make;
        Model = model;
        Year = year;
        Fuel = fuel;
        Body = body;
    }

    public override string ToString()
    {
        return $"{Make} {Model} ({Year}), {Fuel}, {Body}";
    }
}


public class Fleet
{
    private List<Transport> vehicles = new List<Transport>();


    public void AddVehicle(Transport vehicle)
    {
        vehicles.Add(vehicle);
    }


    public void RemoveVehicle(Transport vehicle)
    {
        vehicles.Remove(vehicle);
    }


    public void ListVehicles()
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("Автопарк пуст.");
        }
        else
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}


class Program
{
    static void Main()
    {

        Fleet fleet = new Fleet();


        var car1 = new Transport("Toyota", "Camry", 2020, FuelType.Petrol, BodyType.Sedan);
        var car2 = new Transport("Tesla", "Model 3", 2021, FuelType.Electric, BodyType.Sedan);
        var bus1 = new Transport("Mercedes", "Sprinter", 2022, FuelType.Diesel, BodyType.Bus);


        fleet.AddVehicle(car1);
        fleet.AddVehicle(car2);
        fleet.AddVehicle(bus1);


        Console.WriteLine("Транспортные средства в автопарке:");
        fleet.ListVehicles();


        Console.WriteLine("\nУдаление Tesla Model 3:");
        fleet.RemoveVehicle(car2);


        fleet.ListVehicles();
    }
}
