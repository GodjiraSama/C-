using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aluno_ivo
{
        class Program
        {
            class Aluno // config da class aluno e o array de quantas notas
            {
                private string nome;
                private int numero;
                private int[] nota = new int[5];



                public Aluno() // config do aluno 0
                {
                    nome = "N/A";
                    numero = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        nota[i] = 0;
                    }
                }

                public Aluno(string str, int a, int[] mat) // config de cada aluno
                {
                    nome = str;
                    numero = a;
                    for (int i = 0; i < 5; i++)
                    {
                        nota[i] = mat[i];
                    }
                }



                public string Nome { get => nome; set => nome = value; } 
                public int Numero { get => numero; set => numero = value; }
                public int[] Nota { get => nota; set => nota = value; }



                public override string ToString() // output de cada aluno
                {
                    return "O aluno " + nome + " com o numero " + numero + " teve de notas :";
                }
            }
            static void Main(string[] args)
            {

            }
        }
    }