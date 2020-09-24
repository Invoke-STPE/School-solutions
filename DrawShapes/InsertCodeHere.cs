namespace DrawShapes
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // SHAPE A (10 stars in a single row)
            //
            // **********
            //
            for (int i = 1; i <= 10; i++) 
            {
                DrawingTool.DrawOneStar();
            }
            System.Console.WriteLine();
            // SHAPE B (5 stars in a single row, separated by spaces)
            //
            // * * * * * 
            //
            for (int i = 1; i <= 10; i++)
            {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneSpace();
            }
            System.Console.WriteLine();

            // SHAPE C  (10 rows of 10 stars each)
            //
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            //
            for (int x = 1; x <= 10; x++) 
            {
                for (int y = 1; y <= 10; y++)
                {
                    DrawingTool.DrawOneStar();
                }
                System.Console.WriteLine();
            }

            // SHAPE D (a triangle, I guess...)
            //
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            //

            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1 ; x >= y; y++) 
                {
                    DrawingTool.DrawOneStar();
                }
                System.Console.WriteLine();
            }

            // SHAPE E (X)
            //
            // *        *
            //  *      * 
            //   *    *   
            //    *  *    
            //     **     
            //     **     
            //    *  *    
            //   *    *   
            //  *      * 
            // *        *

        System.Console.WriteLine("=======OPGAVE KRYDS============");
            
            int firstPos = 1;
            int lastPos = 10;
            for (int y = 1; y <= 10; y++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    if (x == firstPos || x == lastPos) {
                        DrawingTool.DrawOneStar();
                    } else { 
                        DrawingTool.DrawOneSpace();
                     }

                }
                firstPos += 1;
                lastPos -= 1;
                System.Console.WriteLine();
            }
            // The LAST line of code should be ABOVE this line

        }
    }
}