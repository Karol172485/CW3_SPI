using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {

        Console.ForegroundColor
            = ConsoleColor.Yellow;

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Clear();


        Console.WriteLine("Hello, what's Your name?");

        var name = Console.ReadLine();

        var currentDate = DateTime.Now;

        Console.WriteLine($"{Environment.NewLine} Hi {name}, the current time is: {currentDate:t}, on a {currentDate:d}\n  ~Karol Piotrowski, CW3");

        Console.Write($"{Environment.NewLine} Press any button to exit the console view..");

        Console.ReadKey(true);

    }
}