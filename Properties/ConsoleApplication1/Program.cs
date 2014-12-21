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
            Properties prop = new Properties();
            prop.SomeField = 10;
            prop.SomeRandomVarible = 3;
        }
    }

    class Properties
    {
        private int _someField;

        public int SomeField
        {
            get //a read-only accessor 
            {
                return _someField;
            }
            set //a write-only accessor
            {
                _someField = value; //value is an inbuilt keyword used in these get-set acessors
            }
        }

        //Look at the above code; Just to encapsulate a single class variable you have to go through so much
        //We don't want that; Look at me; We'll do this :

        //**Introducing Auto-implemented variable, complier creates a back-end private variable for you and you!!
        public int SomeRandomVarible{ get; set; } //That's it. No more worries; we got everything covered up for you; happy coding;
    }
}
