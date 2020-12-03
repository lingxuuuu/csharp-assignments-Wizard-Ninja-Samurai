using System;

namespace human
{
    public class Samurai : Human
    {
        //Samurai should have a default health of 200
        public Samurai(string name) : base(name)
        {
            Name = name;
            Health = 200;
        }

        //Provide an override Attack method to Samurai, 
        //which calls the base Attack and reduces the target to 0 
        //if it has less than 50 remaining health points.

        public override void Attack(Human target)
        {
            if (target.Health < 50)
            {
                target.Health = 0;
            }
            else
            {
                base.Attack(target);
            }

        }

        //Samurai should have a method called Meditate, 
        //which when invoked, heals the Samurai back to full health

        public void Meditate()
        {
            Health = 200;
            Console.WriteLine($"{Name} has recovered 200 hp!");
        }

    }
}