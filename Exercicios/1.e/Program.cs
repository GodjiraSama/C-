using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.e
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Quantas strings tem o vetor?\n");
            n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            int contador = 0, check = 0; ;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Qual é o " + (i + 1) + "º elemento do vetor?\n");
                str[i] = Console.ReadLine();
                if (i == 0)
                {
                    contador = str[0].Length;
                }
                else if (str[i].Length != contador)
                {
                    Console.WriteLine("false");
                    Console.ReadKey();
                    check++;
                    break;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("true");
                Console.ReadKey();
                System.Threading.Thread.Sleep(69420);
            }
        }
    }
}


