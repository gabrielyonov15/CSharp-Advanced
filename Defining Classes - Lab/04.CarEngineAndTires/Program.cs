namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Engine engine = new Engine(300, 3.0);
            Tire[] tires = new Tire[4]
            {
                new Tire(2020, 2.2),
                new Tire(2020, 2.2),
                new Tire(2020, 2.5),
                new Tire(2020, 2.5)
            };
            Car car = new Car("BMW", "X5", 2022, 60, 10, engine, tires);
            Console.WriteLine(car.WhoAmI());
        }
    }
}