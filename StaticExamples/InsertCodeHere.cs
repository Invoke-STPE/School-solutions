using System;
using System.Collections.Generic;

namespace StaticExamples
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            #region ListMethods test
            List<int> aList = new List<int> { 23, 86, 51, 11, 39 };
            ListMethods listMethodsObject = new ListMethods();

            int smallest = ListMethods.FindSmallestNumber(aList);
            Console.WriteLine($"The smallest number in the list is : {smallest}");

            int average = ListMethods.FindAverage(aList);
            Console.WriteLine($"The average of the list is : {average}"); 
            #endregion

            #region CarObject test
            Car car1 = new Car("AAAA", 50);
            car1.LicensePlate = "AAAAAAA";
            car1.LicensePlate = "AAAAAAA";
            car1.LicensePlate = "AAAAAAA";
            car1.LicensePlate = "AAAAAAA";
            car1.Price = 100;
            Car car2 = new Car("BBBB", 5000);
            car2.Price = 100;
            car2.Price = 100;
            System.Console.WriteLine(Car.PrintUsageStatistics());
            #endregion

            // The LAST line of code should be ABOVE this line
        }
    }
}