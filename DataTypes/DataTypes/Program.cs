using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datatype conversions
            //Implicit conversion and explicit conversion

            //Implicit conversion - Compiler converts data for you
            int i = 10;
            float f = i;
            //float is a bigger data type, so it doesnt have a problem holding int

            //Explicit conversion - User have to convert datatypes
            float f2 = 2123.45F;
            //this doesnot work int i2 = f2; there will be loss of data 
            //because of difference in storage capacity

            //So, we do it explicitly in either 2 ways
            //Typecase conversion or System.Convert class

            int i2 = (int) f2;

            int i3 = Convert.ToInt16(f2);

            //convert has many functions

            //checkout typecast's TryParse() method

            int Result = 0;
            string str = "123Whatup";

            bool isConversionSuccessful = int.TryParse(str, out Result);

            //So TryParse returns a boolean
            //there is also Parse. Use it when you're sure that it is going to work

        }
    }
}
