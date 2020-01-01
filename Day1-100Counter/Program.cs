using System;

namespace Day1_100Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            Console.WriteLine("För ojämna siffror tryck 1, för jämna, tryck 2");
            choice = Console.ReadLine();
            for (int i = 1; i < 101; i++)
            {
                if (choice == "1")
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (choice == "2")
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
