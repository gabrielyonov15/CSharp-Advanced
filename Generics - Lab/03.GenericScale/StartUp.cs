using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            EqualityScale<int> intScale = new EqualityScale<int>(5, 5);
            Console.WriteLine(intScale.AreEqual());  
            EqualityScale<string> stringScale = new EqualityScale<string>("Pesho", "Pesho");
            Console.WriteLine(stringScale.AreEqual());  
            EqualityScale<int> intScaleDifferent = new EqualityScale<int>(5, 10);
            Console.WriteLine(intScaleDifferent.AreEqual());  
        }
    }
}