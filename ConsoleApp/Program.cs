using System;
using UnitTests;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(new SimpleArithmetic().Division(0, 0).Equals(float.NaN));
            Console.Read();
        }
    }
}