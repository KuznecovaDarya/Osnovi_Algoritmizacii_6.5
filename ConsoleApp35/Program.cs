using System;
using static System.Console;
using static System.Convert;

using System.Collections.Generic;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            var chisla = new List<int>();
            chisla.Add(1);
            chisla.Add(2);
            chisla.Add(3);
            chisla.Add(4);
            chisla.Add(5);
            chisla.Add(-1);
            chisla.Add(-2);
            chisla.Add(-3);
            chisla.Add(-4);
            chisla.Add(-5);

            foreach (var chislo in chisla)
            {
                Console.Write(chislo + ";\n");
            }
            Console.WriteLine();

            for (int j = 0; j < 5; j++)
            {
                chisla.Insert(chisla.Count / 2, 0);
            }

            foreach (var chislo in chisla)
            {
                Console.Write(chislo + ";\n");
            }
            Console.WriteLine();

            for (int j = 0; j < 5; j++)
            {
                chisla.Remove(chisla[0]);
                chisla.Remove(chisla[chisla.Count - 1]);
                break;
            }

            foreach (var chislo in chisla)
            {
                Console.Write(chislo + ";\n");
            }
        }
    }
}
