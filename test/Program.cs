using System;

namespace FunctionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (int number in numbers) {
                System.Console.WriteLine(number);
            }
        }
    }
}
