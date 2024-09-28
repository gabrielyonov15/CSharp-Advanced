namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car1 = new Car();
            Console.WriteLine(car1.WhoAmI());
            Car car2 = new Car("BMW", "X5", 2022);
            Console.WriteLine(car2.WhoAmI());
            Car car3 = new Car("Audi", "A4", 2023, 60, 7.5);
            Console.WriteLine(car3.WhoAmI());
        }
    }
}