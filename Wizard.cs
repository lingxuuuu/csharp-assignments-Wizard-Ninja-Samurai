using System;

namespace human
{
    public class Wizard : Human
    {
        // Wizard should have a default health of 50 and intelligence of 25
        public Wizard(string name) : base(name)
        {
            Name = name;
            Health = 50;
            Intelligence = 25;
        }

        //Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
        public int Heal(Human target)
        {
            int cure = Intelligence * 10;
            target.Health += cure;
            Console.WriteLine($"{Name} has healed {target.Name} and restored {cure.ToString()} hp!");
            return target.Health;
        }

        // Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence 
        //and heals the Wizard by the amount of damage dealt
        public override void Attack(Human target)
        {

            target.Health -= Intelligence * 5;
            Console.WriteLine($"{Name} attacked {target.Name} for {Intelligence * 5} damage!");
            Health += Intelligence * 5;
        }
    }

}
