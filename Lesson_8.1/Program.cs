using System;
using System.Collections.Generic;


namespace Lesson_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> testList = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                testList.Add(random.Next(101));
            }
            foreach (var e in testList)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            testList.RemoveAll(x => x >= 25 && x <= 50);
            foreach (var e in testList)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine("Yra");
            Console.ReadKey();
        }
    }
}
