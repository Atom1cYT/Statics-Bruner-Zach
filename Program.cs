using System;

namespace Statics_Bruner_Zach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intergers Adds subtract multiply and divid all numbers in command promprt to get the equal
            Console.WriteLine("Integer Methods");
            Console.WriteLine(Calculate.Add(15, 88));
            Console.WriteLine(Calculate.Sub(78, 88));
            Console.WriteLine(Calculate.Mult(8, 9));
            Console.WriteLine(Calculate.Div(77, 8));

            //Floats Adds subtract multiply and divid all numbers in command promprt to get the equal
            Console.WriteLine("\nFloat Methods");
            Console.WriteLine(Calculate.Add(15.55f, 88.65f));
            Console.WriteLine(Calculate.Sub(78.48f, 88.89f));
            Console.WriteLine(Calculate.Mult(8.99f, 9.65f));
            Console.WriteLine(Calculate.Div(77.265f, 8.0f));
        }
    }
}
