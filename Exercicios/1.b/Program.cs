using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.b
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Escreva o seu nome:");
            nome = Console.ReadLine();
            if (nome=="Bartolomeu")
            {
                Console.WriteLine("Dá cá o meu");
            }
            else
            Console.WriteLine("Olá " + nome);
            System.Threading.Thread.Sleep(5000);
        
        }
    }
}
