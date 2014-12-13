using System;

namespace BuiltInTypesStringTypes
{
    class Program
    {
        static void Main()
        {
            sbyte sb = 8; //8bits
            byte b = 8; //8 bits
            short s = 16; //16 bits
            ushort us = 16; //16 bits
            int i = 32; //32 bits
            uint ui = 32; //32 bits
            long l = 64; //64 bits
            ulong ul = 64; //64 bits

            Console.WriteLine("Signedbyte      sbyte Min:{0} Max:{1}",sbyte.MinValue,sbyte.MaxValue);
            Console.WriteLine("Byte             byte Min:{0} Max:{1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Short           short Min:{0} Max:{1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Unsigned Short  short Min:{0} Max:{1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Integer           int Min:{0} Max:{1}",int.MinValue, int.MaxValue);
            Console.WriteLine("Unsigned Integer uint Min:{0} Max:{1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("Long             long Min:{0} Max:{1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Unsigned Long   ulong Min:{0} Max:{1}", long.MinValue, long.MaxValue);
            Console.WriteLine("double has 15-16 significant digits");
            Console.WriteLine("decimal datatype has 25 significant digits");
            Console.WriteLine("Press Any key to exit");
            Console.ReadKey();

            Console.WriteLine("There is a difference between string and String in csharp");
            Console.WriteLine("Ofcourse both does the same thing, they are different");
            Console.WriteLine("string means System.String just like int means System.Int32");

            Console.WriteLine("\n Printing special characters which are not otherwise printable on C#");

            Console.WriteLine("This escapes the backslash");
            string folderName = "C:\\Users\\vreddy\\downloads";
            Console.WriteLine(folderName);

            Console.WriteLine("String Verbatim");
            string folderName2 = @"C:\\Users\\vreddy\\downloads";
            Console.WriteLine(folderName2);
            Console.WriteLine("you might notice that there are 2 backslashes, first backslash is not helpingi n escape sequences");
            Console.WriteLine("you might notice that there are 2 backslashes, first backslash is not helpingi n escape sequences");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
