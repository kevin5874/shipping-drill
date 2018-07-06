using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Package package = new Package(0,0,0,0);
            package.getPackage();
            package.totalCost();
        }
    }
}
