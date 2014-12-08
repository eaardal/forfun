using System;
using System.Threading;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DrawTree(12, 2);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        static void DrawTree(int treeHeight, int trunkHeight)
        {
            var rnd = new Random();
            var branchCounter = treeHeight;
            while (branchCounter > 0)
            {
                var branchWidth = ((treeHeight - branchCounter) * 2);
                var spaces = treeHeight + branchCounter;

                for (var i = spaces; i > 0; i--)
                    Console.Write(" ");

                for (var i = branchWidth; i > 0; i--)
                {
                    Console.ForegroundColor = rnd.Next(100) > 60 ? (ConsoleColor) Enum.Parse(typeof (ConsoleColor), Enum.GetNames(typeof (ConsoleColor))[rnd.Next(1, 15)]) : ConsoleColor.DarkGreen;
                    Console.Write(rnd.Next(0, 9));
                }

                Console.Write("\n");
                branchCounter--;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            for (var i = 0; i < trunkHeight; i++)
            {
                var spaces = ((treeHeight * 2) - 1);
                for (var j = spaces; j > 0; j--)
                {
                    Console.Write(" ");
                }
               
                Console.Write("00");
                Console.Write("\n");
            }
        }
    }
}
