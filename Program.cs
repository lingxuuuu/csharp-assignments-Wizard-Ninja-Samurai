using System;
using System.Collections.Generic;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var NewHuman = new Human("Lee", 10, 50, 5, 20);
            Console.WriteLine($"This is first guy {NewHuman.Name}");
            Console.WriteLine(NewHuman.Strength);
            Console.WriteLine(NewHuman.Intelligence);
            Console.WriteLine(NewHuman.Dexterity);
            Console.WriteLine(NewHuman.Health);
            NewHuman.Attack(NewHuman);

            Wizard wizardA = new Wizard("WizardA");
            Ninja ninjaB = new Ninja("NinjaB");
            Samurai samuraiC = new Samurai("SamuraiC");
            samuraiC.Attack(ninjaB);
            ninjaB.Attack(wizardA);
            wizardA.Attack(samuraiC);
            ninjaB.Steal(ninjaB);
            samuraiC.Meditate();
            wizardA.Heal(ninjaB);
        }
    }
}