using System;

namespace HappyProgrammersDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Matrix Matrix = new Matrix();

            Console.Title = "Happy Programmer's Day";
            ConsoleColor currentColor = ConsoleColor.Green;

            int colorIndex = 0;
            char[,] matrix = new char[10, 75];

            while (true)
            {
                switch (colorIndex)
                {
                    case 0:
                        currentColor  = ConsoleColor.Red;
                        break;
                    case 1:
                        currentColor = ConsoleColor.Yellow; // оранжевого после желтого не хватает))
                        break;
                    case 2:
                        currentColor = ConsoleColor.Green;
                        break;
                    case 3:
                        currentColor = ConsoleColor.Blue;
                        break;
                    case 4:
                        currentColor = ConsoleColor.DarkBlue;
                        break;
                }

                matrix = Matrix.GetMatrix(matrix);
                Matrix.PrintMatrix(matrix, currentColor);

                colorIndex++;
                if (colorIndex == 5) colorIndex = 0;

                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
