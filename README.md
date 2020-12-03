# csharp-assignments-Wizard-Ninja-Samurai

## Assignment: Wizard, Ninja, Samurai
We are going to be revisiting our Human class and building out three new classes that all inherit from it.

class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
     
    public int Health
    {
        get { return health; }
    }
     
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    }
     
    public Human(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        health = hp;
    }
     
    // Build Attack method
    public int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.health;
    }
}

 ## Create a class for a Ninja, a Wizard, and a Samurai. For this assignment, you will need to modify your Human class.

 Wizard should have a default health of 50 and Intelligence of 25
 Ninja should have a default dexterity of 175
 Samurai should have a default health of 200
 Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
 Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
 Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.
 Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
 Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
 Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.
