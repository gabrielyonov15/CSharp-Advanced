using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tiresCollection = new List<Tire[]>();
            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tireData = input.Split();
                Tire[] currentTires = new Tire[4];
                for (int i = 0; i < 4; i++)
                {
                    int year = int.Parse(tireData[2 * i]);
                    double pressure = double.Parse(tireData[2 * i + 1]);
                    currentTires[i] = new Tire(year, pressure);
                }
                tiresCollection.Add(currentTires);
            }
            List<Engine> engines = new List<Engine>();
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineData = input.Split();
                int horsePower = int.Parse(engineData[0]);
                double cubicCapacity = double.Parse(engineData[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));
            }
            List<Car> cars = new List<Car>();
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carData = input.Split();
                string make = carData[0];
                string model = carData[1];
                int year = int.Parse(carData[2]);
                double fuelQuantity = double.Parse(carData[3]);
                double fuelConsumption = double.Parse(carData[4]);
                int engineIndex = int.Parse(carData[5]);
                int tiresIndex = int.Parse(carData[6]);
                Engine engine = engines[engineIndex];
                Tire[] tires = tiresCollection[tiresIndex];
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                double tiresPressureSum = car.Tires.Sum(t => t.Pressure);
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && tiresPressureSum >= 9 && tiresPressureSum <= 10)
                {
                    car.Drive(20);
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}