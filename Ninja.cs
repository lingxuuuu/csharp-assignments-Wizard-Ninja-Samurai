
using System;

namespace human
{
    public class Ninja : Human
    {
        // Ninja should have a default dexterity of 175
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 175;
        }

        // Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
        public override void Attack(Human target)
        {
            int damage = 5 * Dexterity;
            Random rand = new Random();
            int chance = rand.Next(0, 100);
            if (chance <= 20)
            {
                target.Health = target.Health - 10 - damage;
            }
            else
            {
                target.Health = target.Health - damage;
            }

            Console.WriteLine($"{Name} attacked {target.Name} for a damage!");

        }
        // Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.
        public void Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine($"{Name} has stolen 5 hp from {target.Name}!");
        }
    }
}