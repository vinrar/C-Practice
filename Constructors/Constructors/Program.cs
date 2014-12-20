using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Default Constructor - which is called when we initialize a class object
            //Created Constructors - which I'm going to do right now

            School sh1 = new School(); //default constructor is overridden by my constructor()            
            Console.WriteLine(sh1.Class);
            School sh2 = new School(1, "Rattu Babu"); // this calls my constructor(sbyte, strin)
            Console.WriteLine(sh2.Class);
        }
    }

    class School
    {
        private sbyte _class;
        private string _name;

        public sbyte Class 
        {
            get { return this._class; }
        }

        public School(sbyte Class, string Name)
        {
            this._class = Class;
            this._name = Name;
        }

        public School() 
            : this(0, "No Name Given") //Constructor calling another constructor
        {            
        }

        private School(string str) // a private constructor cannot be called from outside this class
        {
            this._class = 1;
            this._name = "Laddu Babu in a private constructor";
        } // it can only be called by another constructor

        public School(sbyte cls)
            : this("Private")
        { }
    }
}
