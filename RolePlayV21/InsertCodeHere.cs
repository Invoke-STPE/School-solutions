using System;
// ReSharper disable ConvertIfStatementToConditionalTernaryExpression

namespace RolePlayV21
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            NumberGenerator generator = new NumberGenerator();
            BattleLog log = new BattleLog();

            // Battle logic (1-on-1)
            #region 1-on-1 battle logic
            Hero theHero = new Hero(generator, log, "Olafur", 100, 10, 30);
            Beast theBeast = new Beast(generator, log, "Zakhial", 90, 10, 25);

            while (!theHero.Dead && !theBeast.Dead)
            {
                int damageByHero = theHero.DealDamage();
                theBeast.ReceiveDamage(damageByHero);

                if (!theBeast.Dead)
                {
                    int damageByBeast = theBeast.DealDamage();
                    theHero.ReceiveDamage(damageByBeast);
                }
            }

            log.PrintLog();
            Console.WriteLine();
            if (theBeast.Dead)
            {
                Console.WriteLine($"The Hero {theHero.Name} was Victorious!!");
            }
            else
            {
                Console.WriteLine($"The Beast {theBeast.Name} won... ;-(");
            }
            log.Save("==================================");
            #endregion


            // New battle logic (1-on-many)
            #region 1-on-many battle logic

            Beast goblin1 = new Beast(generator, log, "Goblin1", 15, 5, 10);
            Beast goblin2 = new Beast(generator, log, "Goblin2", 15, 5, 10);
            Beast goblin3 = new Beast(generator, log, "Goblin3", 15, 5, 10);
            Beast goblin4 = new Beast(generator, log, "Goblin4", 15, 5, 10);
            BeastArmy goblinArmy = new BeastArmy();
            
            goblinArmy.AddBeast(goblin1);
            goblinArmy.AddBeast(goblin2);
            goblinArmy.AddBeast(goblin3);
            goblinArmy.AddBeast(goblin4);

            int battles = 100;
        while (battles > 0) 
        {
            while (!theHero.Dead && !goblinArmy.Dead) 
            {
                int damageByHero = theHero.DealDamage();
                goblinArmy.ReceiveDamage(damageByHero);

                if (!goblinArmy.Dead)
                {
                    int damageByGoblins = goblinArmy.DealDamage(); 
                    theHero.ReceiveDamage(damageByGoblins);
                }
                battles -= 1;
            }
        }
            log.PrintLog();

            double beastWinRate = goblinArmy.Wins;
            double heroWinRate = theHero.Wins;

            System.Console.WriteLine("Golins have won " + beastWinRate / 100 + " % of games, out of 100.");
            System.Console.WriteLine("hero have won " + heroWinRate / 100 + " % of games, out of 100.");


            // TODO - implement 1-on-many battle logic

            #endregion

            // The LAST line of code should be ABOVE this line
        }
    }
}