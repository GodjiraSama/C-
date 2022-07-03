using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos diabos?\n");
            int n = int.Parse(Console.ReadLine());
            Aluno[] alunos = new Aluno[n];

        }
    }

    class Aluno
    {
        private string nome;

        private int numero;

        private int[] notas = new int[5];
    }

    public Alunos(string nome, int numero, int notas)
    {

    }
}
