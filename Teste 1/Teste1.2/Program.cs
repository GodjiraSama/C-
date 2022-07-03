using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite um número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número");
            n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2 ;

            Console.WriteLine("Soma: " + soma);

            System.Threading.Thread.Sleep(5000);
        }
    }
}
