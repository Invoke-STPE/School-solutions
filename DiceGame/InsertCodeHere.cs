namespace DiceGame
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            DiceCup dicecup = new DiceCup();
            System.Console.WriteLine($"Total value: {dicecup.TotalValue}");
            dicecup.Shake();
            System.Console.WriteLine($"Total value: {dicecup.TotalValue}");
            DiceCup dicecup2 = new DiceCup(20);
            System.Console.WriteLine($"Total value: {dicecup2.TotalValue}");
            dicecup2.Shake();
            System.Console.WriteLine($"Total value: {dicecup2.TotalValue}");
            int x;

            System.Console.WriteLine(x);
            // The LAST line of code should be ABOVE this line
        }
    }
}