using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Escreva o seu nome:");
            nome=Console.ReadLine();
            Console.WriteLine("Olá " + nome);
            System.Threading.Thread.Sleep(5000);
        }
    }
}
