namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            car.Make = "Toyota";
            car.Model = "Corolla";
            car.Year = 2020;
            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
        }
    }
}