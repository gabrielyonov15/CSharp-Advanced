using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace _07.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                List<Tire> tires = new List<Tire>();
                for (int j = 0; j < 4; j++)
                {
                    float tirePressure = float.Parse(input[5 + j * 2]);
                    int tireAge = int.Parse(input[6 + j * 2]);
                    tires.Add(new Tire(tirePressure, tireAge));
                }
                cars.Add(new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tires));
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "fragile" && car.Tires.Exists(t => t.Pressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else 
            if (command == "flammable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "flammable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}