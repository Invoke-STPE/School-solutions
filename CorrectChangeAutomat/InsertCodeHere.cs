using System;

namespace CorrectChangeAutomat
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double customerChange = 234;
            while (customerChange > 0)
            {
                if (customerChange >= 200) 
                {
                    System.Console.WriteLine($"Kunde har modtaget en 200 kr seld");
                    customerChange = customerChange - 200;
                }
                else if (customerChange >= 50) 
                {
                    System.Console.WriteLine($"Kunde har modtaget en 50'er");
                    customerChange = customerChange - 200;
                }
                else if (customerChange >= 20)
                {
                    System.Console.WriteLine($"Kunde har modtaget en 20'er");
                    customerChange = customerChange - 20;
                }
                else if (customerChange >= 10) 
                {
                    System.Console.WriteLine($"Kunde har modtaget en 10'er");
                    customerChange = customerChange - 10; 
                }
                else if (customerChange >= 5) 
                {
                    System.Console.WriteLine($"Kunde har modtaget en 5'er");
                    customerChange = customerChange - 5; 
                }
                else if (customerChange >= 2) 
                {
                    System.Console.WriteLine($"Kunde har modtaget en 2 kr");
                    customerChange = customerChange - 2;
                }
                else if (customerChange >= 1)
                {
                    System.Console.WriteLine($"Kunde har modtaget 1 kr.");
                    customerChange = customerChange -1;
                }
                else if (customerChange >= 0.5) 
                {
                    System.Console.WriteLine($"Kunde har modtaget en halv kr.");
                    customerChange = customerChange - 0.5;
                }
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}