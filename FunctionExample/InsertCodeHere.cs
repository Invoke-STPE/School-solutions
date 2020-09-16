using System;

namespace FunctionExample
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // double rect1x1 = 4.5;
            // double rect1y1 = 2.3;
            // double rect1x2 = 8.2;
            // double rect1y2 = 4.9;

            double area1 = AreaOfRectangle(4.5, 2.3, 8.2, 4.9);
            Console.WriteLine($"Area of first rectangle is {area1}");

            // double rect2x1 = -3.2;
            // double rect2y1 = 1.1;
            // double rect2x2 = 3.7;
            // double rect2y2 = 5.6;

            double area2 = AreaOfRectangle(-3.2, 1.1, 3.7, 5.6);
            Console.WriteLine($"Area of second rectangle is {area2}");
            // The LAST line of code should be ABOVE this line
        }

        public double AreaOfRectangle(double x1, double y1, double x2, double y2)
        {
            // Implement AreaOfRectangle, such that it returns the area
            // of a rectangle defined by (x1, y1) and (x2, y2)
            return Math.Abs((x1 - x2) * (y1 - y2));
        }
    }
}