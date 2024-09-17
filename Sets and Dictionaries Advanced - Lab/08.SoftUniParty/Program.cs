namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vipGuests = new HashSet<string>();
            var regularGuests = new HashSet<string>();
            string input;
            bool partyStarted = false;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "PARTY")
                {
                    partyStarted = true;
                    continue;
                }

                if (partyStarted)
                {
                    vipGuests.Remove(input);
                    regularGuests.Remove(input);
                }
                else
                {
                    if (char.IsDigit(input[0]))
                    {
                        vipGuests.Add(input);
                    }
                    else
                    {
                        regularGuests.Add(input);
                    }
                }
            }
            var notArrivedGuests = vipGuests.Concat(regularGuests).ToList();
            Console.WriteLine(notArrivedGuests.Count);
            foreach (var guest in notArrivedGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}