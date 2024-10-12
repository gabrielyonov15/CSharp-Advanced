namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameAddressInput = Console.ReadLine().Split();
            string fullName = $"{nameAddressInput[0]} {nameAddressInput[1]}";  
            string address = nameAddressInput[2];  
            Tuple<string, string> nameAddressTuple = new Tuple<string, string>(fullName, address);
            Console.WriteLine(nameAddressTuple);
            string[] nameBeerInput = Console.ReadLine().Split();
            string name = nameBeerInput[0];
            int beerAmount = int.Parse(nameBeerInput[1]);
            Tuple<string, int> nameBeerTuple = new Tuple<string, int>(name, beerAmount);
            Console.WriteLine(nameBeerTuple);
            string[] intDoubleInput = Console.ReadLine().Split();
            int integer = int.Parse(intDoubleInput[0]);
            double floatingPoint = double.Parse(intDoubleInput[1]);
            Tuple<int, double> intDoubleTuple = new Tuple<int, double>(integer, floatingPoint);
            Console.WriteLine(intDoubleTuple);
        }
    }
}