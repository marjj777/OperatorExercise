using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if(a == 17 && b == 4)
            {
                Console.WriteLine($"The answer is {quotient} and {remainder}");
            }


        }
    }
}
