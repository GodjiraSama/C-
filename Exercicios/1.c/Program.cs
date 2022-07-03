using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace _1.c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o seu nome Completo\t");
            Console.ReadLine();
            string fullName = "Daniel Filipe Sousa Fernandes";
            var names = fullName.Split(' ');
            string firstName = names[0];
            string lastName = names[1];

            Console.WriteLine("Primeiro Nome: " + firstName);
            Console.WriteLine("Último Nome: " + lastName);

            System.Threading.Thread.Sleep(5000);

        }
    }
}
