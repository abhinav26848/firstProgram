using System;

namespace firstProgram
{
    internal class Program
    {
        public static void pattern() {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("hello world");
        //    Console.WriteLine("first program");
        //    pattern();
        //}
    }

}
