using System;

namespace challange
{
    class Program
    {
        static void Main(string[] args)
        {
            var passcode = "";
            while (passcode != "secret") { 
            Console.WriteLine("Write you passcode please:");
             passcode = Console.ReadLine();

            if(passcode != "secret")
            {
                Console.WriteLine("you are Not authenticated. Please try again!.");
            }
            }
            Console.WriteLine("you are authenticated. Thank you for your loggin");
        }
    }
}
