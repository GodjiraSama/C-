using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.f
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Quantas strings tem o vetor?\n");
            n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            int contador = 0;
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
                    _ = contador + str[i].Length;
                    return ;
                }
            }
           
        }
    }
}
