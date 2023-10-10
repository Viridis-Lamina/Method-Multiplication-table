using System;

namespace MethodMulti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            Multiplication (number);

        }

        public static void Multiplication (int number) 
        { 
        
            for (int M = 2; M < 11; M++)
            {
                int answer = number * M;
                Console.WriteLine("{0,2} * {1,2} = {2,2}",M,number,answer);

            }


        }
    }
}