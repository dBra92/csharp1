using System;
using System.Collections.Generic;
using Genericss.Services;

namespace Genericss;
class Program
{
    static void Main(string[] args)
    {
        PrintService<int> ps = new PrintService<int>();

        System.Console.Write("How many values?:");
        int hmv = int.Parse(Console.ReadLine());

        for(int i = 0; i < hmv;i++)
        {
            int x = int.Parse(Console.ReadLine());
            ps.AddValue(x);
        }

        int a = ps.First();
        int b = a + 2;
        System.Console.WriteLine("------");
        System.Console.WriteLine(b);
        System.Console.WriteLine("------");

        ps.Print();
        System.Console.WriteLine($"First:{ps.First()}");
    }
}
