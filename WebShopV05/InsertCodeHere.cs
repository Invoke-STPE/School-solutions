using System;
#pragma warning disable 219

namespace WebShopV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            int noOfBooksInOrder = 8;
            int noOfDVDsInOrder = 3;
            int noOfGamesInOrder = 2;

            double totalPrice = (((netPriceBook * 1.10) * noOfBooksInOrder) + ((netPriceDVD * 1.10) * noOfDVDsInOrder) + ((netPriceGame * 1.10) * noOfGamesInOrder) + 49) * 1.02; // This variable should contain the total price for the order

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}