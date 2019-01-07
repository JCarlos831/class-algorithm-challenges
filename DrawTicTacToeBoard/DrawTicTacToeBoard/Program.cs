using System;

namespace DrawTicTacToeBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawBoard(10);
        }

        private static void DrawBoard(int size)
        {
            for (var i = 0; i < size-1; i++)
            {
                for (var j = 0; j < size-1; j++)
                {
                    Console.Write("   |   ");
                }

                Console.WriteLine();
                for (var k = 0; k < size-1; k++)
                {
                    Console.Write("---+---");
                }

                Console.WriteLine();
                for (var l = 0; l < size-1; l++)
                {
                    Console.Write("   |   ");
                }

                Console.WriteLine();
            }
        }
    }
}