using System;

namespace zoo_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add Cage");
            Console.WriteLine("2.Remove Cage");
            Console.WriteLine("3.Add Animal");
            Console.WriteLine("4.Remove Animal");
            Console.WriteLine("5.Iterate Animal");
            Console.WriteLine("6.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: break;
            }
        }
    }
}
