namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameAddressTownInput = Console.ReadLine().Split();
            string fullName = $"{nameAddressTownInput[0]} {nameAddressTownInput[1]}";  
            string address = nameAddressTownInput[2];
            string town = string.Join(" ", nameAddressTownInput, 3, nameAddressTownInput.Length - 3);
            Threeuple<string, string, string> nameAddressTown = new Threeuple<string, string, string>(fullName, address, town);
            Console.WriteLine(nameAddressTown);
            string[] nameBeerDrunkInput = Console.ReadLine().Split();
            string name = nameBeerDrunkInput[0];
            int litersOfBeer = int.Parse(nameBeerDrunkInput[1]);
            bool isDrunk = nameBeerDrunkInput[2] == "drunk";
            Threeuple<string, int, bool> nameBeerDrunk = new Threeuple<string, int, bool>(name, litersOfBeer, isDrunk);
            Console.WriteLine(nameBeerDrunk);
            string[] nameBalanceBankInput = Console.ReadLine().Split();
            string personName = nameBalanceBankInput[0];
            double balance = double.Parse(nameBalanceBankInput[1].Replace(',', '.')); 
            string bankName = nameBalanceBankInput[2];
            Threeuple<string, double, string> nameBalanceBank = new Threeuple<string, double, string>(personName, balance, bankName);
            Console.WriteLine(nameBalanceBank);
        }
    }
}