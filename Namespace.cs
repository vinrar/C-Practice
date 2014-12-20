using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TACA = Organization.TeamA.ClassA;
using TBCA = Organization.TeamB.ClassA;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //there are two ways to declare a namespace
            //Nesting of namespaces is also possible

            //Example 1. //declaring namespaces in the same file or assembly
            //Example 2. //declaring namespaces in a different assembly

            //Example 1. Two teams in an organization have Print methods
            //Calling those methods is the primary purpose of this meeting

            Organization.TeamA.ClassA.Print();
            Organization.TeamB.ClassA.Print();
            //Both the print methods are made from the static keyword
            //When you declare a method or variable as static you dont need
            //to initialize a variable, you can directly call it from class

            //Example1 - part2 - using Alias'es
            Console.WriteLine("Using Alias'es");
            TACA.Print();
            TBCA.Print();

            //-----Example 2-----//
            //Implemented classes in a new class library and since it is in same project
            // imported it with an ease
            Institution.SchoolA.ClassA.Print();
            Institution.SchoolA.ClassB.Print();            
        }
    }
}

namespace Organization
{
    namespace TeamA 
    {
        public class ClassA 
        {
            public static void Print()
            {
                Console.WriteLine("This is Team A!!!! waaah");
            }
        }
    }

    namespace TeamB
    {
        public class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("This is Team B!!! smell these flowers...umma");
            }
        }
    }
}
