using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodsNamespacesAndClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Passing by value, passing by reference, out paramters, array params
            
            //Passing by value
            int X = 5;
            int Y = 7;
            
            Add(X, Y);
            Console.WriteLine("X : {0}, Y : {1}", X, Y);

            //Passing by reference
            Total(ref X, ref Y);
            Console.WriteLine("X : {0}, Y : {1}", X, Y);

            //Out parameters - used when we require more than one output
            int Sum = 0;
            int Product = 0;
            ArithmeticOperations(X, Y, out Sum, out Product);

            Console.WriteLine("Sum : {0}, Product : {1}", Sum, Product);
            
            //Sending arrays as input parameters
            //we must use keyword params while sending arrays
            /*
             * With params you can call your method like this:

                addTwoEach(1, 2, 3, 4, 5);
                Without params, you can’t.

                Additionally, you can call the method with an array as a parameter in both cases:

                addTwoEach(new int[] { 1, 2, 3, 4, 5 });
                That is, params allows you to use a shortcut when calling the method.

                Unrelated, you can drastically shorten your method:

                public static int addTwoEach(params int[] args)
                {
                    return args.Sum() + 2 * args.Length;
                }
             */

            int[] Arr = new int[3];
            Arr[0] = 1;
            Arr[1] = 2;
            Arr[2] = 3;
            SendingArrayAsInput(new int[] {1,2,3});
        }

        private void SendingArrayAsInput(params int[] Arr)
        {
            Console.WriteLine("Look in the comment section");
        }

        private void ArithmeticOperations(int X, int Y, out int Sum, out int Product)
        {
            Sum = X + Y;
            Product = X * Y;
        }

        private void Total(ref int X, ref int Y)
        {
            X = 100;
            Y = 200;
        }

        public static void Add(int X, int Y) 
        {
            //X and Y value are not changed when you update those valeus in this code
            //This is called passing by reference
            X = 10;
            Y = 20;
        }
    }
}
