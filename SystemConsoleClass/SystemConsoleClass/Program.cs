using System;

namespace SystemConsoleClass
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter a Valid UserName");
            string userName = Console.ReadLine();
            //First Way of printing : concatenation
            Console.WriteLine("Welcome by concatenation" + userName);
            //Second way of printing : place-holder syntax
            Console.WriteLine("Welcome by placeholder {0}", userName);
            Console.WriteLine("Press Any Key to Close");
            Console.ReadKey();
        }
    }
}
