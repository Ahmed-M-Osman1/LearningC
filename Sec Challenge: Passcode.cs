using System;

namespace challange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write you passcode please:");
            var passcode = Console.ReadLine();

            if(passcode == "secret")
            {
                Console.WriteLine("you are authenticated. Thank you for your loggin");
            }
            else
            {
                Console.WriteLine("you are Not authenticated. the programe will exit.");
            }
        }
    }
}
