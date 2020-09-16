using System;

namespace RolePlayV11
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior warriorA = new Warrior("Ragnar", 100);
            Warrior warriorB = new Warrior("Lagertha", 100);

            Console.WriteLine($"Warrior A is called {warriorA.Name} is level {warriorA.Level}, with {warriorA.Hp}");
            Console.WriteLine($"Warrior B is called {warriorB.Name} is level {warriorB.Level}, with {warriorB.Hp}");

            var running = true;
            while (running) {
                // Warrior A attacks!
                if (warriorA.Dead == false) {
                    var dmgA = warriorA.DealDamage();
                    warriorB.DecreaseHP(dmgA);
                    System.Console.WriteLine($"Warrior A attacks, damages warrior B for {dmgA}, {warriorB.Hp} left. ");
                } else {
                    System.Console.WriteLine("Warrior B wins!"); 
                    running = false;
                    break;
                    }

                // Warrior B attacks!
                if (warriorB.Dead == false) {
                    var dmgB = warriorB.DealDamage();
                    warriorA.DecreaseHP(dmgB);
                    System.Console.WriteLine($"Warrior B attacks, damages warrior A for {dmgB}, {warriorA.Hp} left. ");
                } else { 
                    System.Console.WriteLine("Warrior A wins!");
                    running = false;
                    break;
                }
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}