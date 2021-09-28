using System;

namespace Ahmed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var a = Console.ReadLine();
            Console.WriteLine("Hallo "+a);
            Console.WriteLine("How old are you?");
            var x = Console.ReadLine();
            Console.WriteLine("you are " + x + " years old");
            Console.WriteLine("what month you were born in?");
            var y = Console.ReadLine();
            Console.WriteLine("you were born in "+y);
        }
    }
}
