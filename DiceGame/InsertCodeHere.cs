namespace DiceGame
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            DiceCup diceCup = new DiceCup();
            System.Console.WriteLine($"total value {diceCup.TotalValue}");
            diceCup.Shake();
            System.Console.WriteLine($"total value {diceCup.TotalValue}");
            diceCup.Shake();
            System.Console.WriteLine($"total value {diceCup.TotalValue}");
            // The LAST line of code should be ABOVE this line
        }
    }
}