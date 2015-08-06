using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AlphabetTimer
{
    class Program
    {
        private readonly static Stopwatch _stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Write the alphabet!");
            Console.ResetColor();
            _stopwatch.Start();
            var input = Console.ReadLine();
            _stopwatch.Stop();
            if (input != null && input.ToLower(CultureInfo.InvariantCulture) == "abcdefghijklmnopqrstuvwxyz")
                Success();
            else
                Failure();
        }

        private static void Failure()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect! :(");
            Console.ResetColor();
            PromptExitSignal();
        }
        
        private static void Success()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success! Time: {0}ms", _stopwatch.ElapsedMilliseconds);
            Console.ResetColor();
            PromptExitSignal();
        }

        private static void PromptExitSignal()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
