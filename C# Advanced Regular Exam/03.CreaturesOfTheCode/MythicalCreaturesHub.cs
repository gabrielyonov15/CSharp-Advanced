using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaturesOfTheCode
{
    public class MythicalCreaturesHub
    {
        public List<Creature> Creatures { get; set; }
        public int Capacity { get; set; }
        public MythicalCreaturesHub(int capacity)
        {
            Capacity = capacity;
            Creatures = new List<Creature>();
        }
        public void AddCreature(Creature creature)
        {
            if (Creatures.Count >= Capacity || Creatures.Any(c => c.Name.Equals(creature.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }
            Creatures.Add(creature);
        }
        public bool RemoveCreature(string name)
        {
            var creature = Creatures.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (creature != null)
            {
                Creatures.Remove(creature);
                return true;
            }
            return false;
        }
        public Creature GetStrongestCreature()
        {
            return Creatures.OrderByDescending(c => c.Health).First();
        }
        public string Details(string creatureName)
        {
            var creature = Creatures.FirstOrDefault(c => c.Name.Equals(creatureName, StringComparison.OrdinalIgnoreCase));
            return creature != null ? creature.ToString() : $"Creature with the name {creatureName} not found.";
        }
        public string GetAllCreatures()
        {
            var orderedCreatures = Creatures.OrderBy(c => c.Name).ToList();
            string result = "Mythical Creatures:";
            foreach (var creature in orderedCreatures)
            {
                result += $"\n{creature.Name} -> {creature.Kind}";
            }
            return result;
        }
    }
}