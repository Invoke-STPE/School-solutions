using System;

namespace RolePlayV12
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Sword swordA = new Sword("MAXKILL", 60, 90);
            Sword swordB = new Sword("THE UNFORGIVEN", 30, 100);
            Sword optSwordA = new Sword("KILLER UPGRADED", 80, 120);
            Warrior warriorA = new Warrior("Ragnar", 200, swordA, optSwordA);
            Warrior warriorB = new Warrior("Lagertha", 240, swordB);

            Console.WriteLine("Just after creation:");
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine();

            int damageFromA = warriorA.DealDamage();
            int damageFromB = warriorB.DealDamage();
            warriorA.ReceiveDamage(damageFromB);
            warriorB.ReceiveDamage(damageFromA);

            Console.WriteLine("After damage:");
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}