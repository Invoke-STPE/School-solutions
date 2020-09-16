using System;

namespace MovieManagerV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            PrintMovie("This way to die,", 1.5, "Steven", "PG", 2006);
            // The LAST line of code should be ABOVE this line
        }
        public void PrintMovie(string title, double length, string director, string rated, int releaseYear){
            System.Console.WriteLine($"Your movie title is: {title}");
            System.Console.WriteLine($"Your movie title is: {length}");
            System.Console.WriteLine($"Your movie title is: {director}");
            System.Console.WriteLine($"Your movie title is: {rated}");
            
            System.Console.WriteLine($"Your movie title is: {releaseYear}, Filmen er {2020 - releaseYear} år gamle");
        }
    }
}