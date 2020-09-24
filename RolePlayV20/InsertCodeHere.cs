using System;

namespace RolePlayV20
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            NumberGenerator theNumberGenerator = new NumberGenerator();
            BattleLog theLog = new BattleLog();

            // Hero theHero = new Hero(theNumberGenerator, theLog);
            // Beast theBeast = new Beast(theNumberGenerator, theLog);
            Player theHero = new Player(theNumberGenerator, theLog, "Hero");
            Player theBeast = new Player(theNumberGenerator, theLog, "Beast");

            // Now battle...How do we do that (Hint: You need a loop)
            bool running = true;
            while (running)
            {
                int whoStarts = theNumberGenerator.Next(1, 2);

                if (whoStarts == 1) 
                {
                    theBeast.ReceiveDamage(theHero.DealDamage());
                }
                if ( whoStarts == 2) 
                {
                    theHero.ReceiveDamage(theBeast.DealDamage());
                }
                if ( (theHero.Dead == true) || (theBeast.Dead == true) ) {
                    running = false;
                }
            }

            theLog.PrintLog();

            // The LAST line of code should be ABOVE this line
        }
    }
}