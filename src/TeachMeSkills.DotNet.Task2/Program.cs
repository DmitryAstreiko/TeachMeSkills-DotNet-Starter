using System;

namespace TeachMeSkills.DotNet.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first string : ");
            var firstStr = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Enter second string : ");
            var secondStr = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Enter third string : ");
            var thirdStr = Console.ReadLine();

            Console.WriteLine($"\n{firstStr} \t{secondStr} \a{thirdStr}");

            Console.ReadKey();
        }
    }
}
