namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var parts = input.Split(", ");
                string direction = parts[0];
                string carNumber = parts[1];
                if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else 
                if (direction == "OUT")
                {
                    parkingLot.Remove(carNumber);
                }
            }
            if (parkingLot.Count > 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}