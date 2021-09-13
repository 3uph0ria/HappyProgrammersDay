using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyProgrammersDay
{
    class Matrix
    {
        private static Random rand = new Random();
        private static string[] lines = new string[]
        {
            "╔╗╔╦══╦═══╦═══╦╗╔╗ ╔═══╦═══╦══╦═══╦═══╦══╦╗──╔╦╗──╔╦═══╦═══╦══╗ ╔══╗╔══╦╗╔╗",
            "║║║║╔╗║╔═╗║╔═╗║║║║ ║╔═╗║╔═╗║╔╗║╔══╣╔═╗║╔╗║║──║║║──║║╔══╣╔═╗║╔═╝ ║╔╗╚╣╔╗║║║║",
            "║╚╝║╚╝║╚═╝║╚═╝║╚╝║ ║╚═╝║╚═╝║║║║║╔═╣╚═╝║╚╝║╚╗╔╝║╚╗╔╝║╚══╣╚═╝║╚═╗ ║║╚╗║╚╝║╚╝║",
            "║╔╗║╔╗║╔══╣╔══╩═╗║ ║╔══╣╔╗╔╣║║║║╚╗║╔╗╔╣╔╗║╔╗╔╗║╔╗╔╗║╔══╣╔╗╔╩═╗║ ║║─║║╔╗╠═╗║",
            "║║║║║║║║──║║───╔╝║ ║║──║║║║║╚╝║╚═╝║║║║║║║║║╚╝║║║╚╝║║╚══╣║║║╔═╝║ ║╚═╝║║║║╔╝║",
            "╚╝╚╩╝╚╩╝──╚╝───╚═╝ ╚╝──╚╝╚╝╚══╩═══╩╝╚╝╚╝╚╩╝──╚╩╝──╚╩═══╩╝╚╝╚══╝ ╚═══╩╝╚╝╚═╝"
        };

        public static char[,] GetMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > 1 && i < 8)
                    {
                        matrix[i, j] = Convert.ToChar(lines[i - 2][j]);
                    }
                    else
                    {
                        int tmp = rand.Next(0, 2);
                        if (tmp == 0)
                        {
                            matrix[i, j] = '0';
                        }
                        else
                        {
                            matrix[i, j] = '1';
                        }
                    }
                }
            }

            return matrix;
        }

        public static void PrintMatrix(char[,] matrix, ConsoleColor currentColor)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i < 2 || i > 7)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = currentColor;
                }

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
