using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.d
{
    class Program
    {

        static void Main(string[] args)
        {
            string frase1 = "";
            int n, contador = 0, numero = 0;
            Console.WriteLine("Quantas frases vai analisar?\n");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + "ª frase.\n");
                frase1 = Console.ReadLine();
                if (frase1.Length > contador)
                {
                    contador = frase1.Length;
                    numero = i;
                }
            }
            Console.WriteLine("Não houve frase maior que a " + (numero+1) + "ª com os seus " + contador + " caracteres!!!\n");
            System.Threading.Thread.Sleep(69420);
        }
    }
}