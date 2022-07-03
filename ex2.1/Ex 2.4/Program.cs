using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2_4
{
    class Program
    {
        public static void CarregarMatriz(string[,] class_data, int rows, int cols)
        {
            for (int r = 0; r < rows; r++)
            {
                Console.WriteLine("\n | Student " + (r + 1) + "\n");

                for (int c = 0; c < cols; c++)
                {
                    if (c == 0)
                        Console.Write(" | Number > ");
                    if (c == 1)
                        Console.Write(" | Age > ");
                    if (c == 2)
                        Console.Write(" | Classification [ Math ] > ");
                    if (c == 3)
                        Console.Write(" | Classification [ Portuguese ] > ");
                    if (c == 4)
                        Console.Write(" | Classification [ English ] > ");

                    class_data[r, c] = Console.ReadLine();
                }
            }
        }
        public static void ImprimirMatriz(string[,] class_data, int rows, int cols)
        {
            for (int r = 0; r < rows; r++)
            {
                Console.WriteLine("\n | Student " + (r + 1) + "\n");

                for (int c = 0; c < cols; c++)
                {
                    if (c == 0)
                        Console.WriteLine(" | Number > " + class_data[r, c]);
                    if (c == 1)
                        Console.WriteLine(" | Age > " + class_data[r, c]);
                    if (c == 2)
                        Console.WriteLine(" | Classification [ Math ] > " + class_data[r, c]);
                    if (c == 3)
                        Console.WriteLine(" | Classification [ Portuguese ] > " + class_data[r, c]);
                    if (c == 4)
                        Console.WriteLine(" | Classification [ English ] > " + class_data[r, c]);
                }

                Console.WriteLine();
            }
        }
        public static float MediaIdade(string[,] class_data, int students)
        {
            int sum_idade = 0;
            float media_idade;
            for (int s = 0; s < students; s++)
            {
                sum_idade += int.Parse(class_data[s, 1]);
            }

            media_idade = sum_idade / students;
            return media_idade;
        }
        public static float MediaTurma(string[,] class_data, int students)
        {
            float nota, sum_notas = 0;
            float media_turma;
            for (int s = 0; s < students; s++)
            {
                nota = float.Parse(class_data[s, 2]) + float.Parse(class_data[s, 3]) + float.Parse(class_data[s, 4]);
                sum_notas += nota;
            }

            media_turma = sum_notas / (students * 3);
            return media_turma;
        }
        public static void MediaDisciplina(string[,] class_data, int students)
        {
            float sum_math = 0, sum_port = 0, sum_eng = 0;
            float media_math, media_port, media_eng;

            for (int s = 0; s < students; s++)
            {
                sum_math += float.Parse(class_data[s, 2]);
                sum_port += float.Parse(class_data[s, 3]);
                sum_eng += float.Parse(class_data[s, 4]);
            }

            media_math = sum_math / students;
            media_port = sum_port / students;
            media_eng = sum_eng / students;

            Console.WriteLine("\n | Media \n");
            Console.WriteLine(" | Math > " + media_math);
            Console.WriteLine(" | Portuguese > " + media_port);
            Console.WriteLine(" | English > " + media_eng);
        }
        public static void NotaAluno(string[,] class_data, int students, float[] media_students)
        {
            for (int s = 0; s < students; s++)
            {
                Console.WriteLine("\n | Student " + class_data[s, 0] + "\n\t|");
                Console.WriteLine(" | Math > " + class_data[s, 2]);
                Console.WriteLine(" | Portuguese > " + class_data[s, 3]);
                Console.WriteLine(" | English > " + class_data[s, 4]);
                media_students[s] = float.Parse(class_data[s, 2] + class_data[s, 3] + class_data[s, 4]);
            }
        }
        public static float MelhorMediaAluno(int students, float[] media_students)
        {
            float melhor_media = 0;
            for (int s = 0; s < students - 1; s++)
            {
                if (media_students[s] > media_students[s + 1])
                {
                    melhor_media = media_students[s];
                }
                else
                {
                    melhor_media = media_students[s + 1];
                }
            }
            return melhor_media;
        }
        public static void AlunosAprovReprov(int students, float[] media_students, ref int aprov, ref int reprov)
        {
            for (int s = 0; s < students; s++)
            {
                if (media_students[s] >= 10)
                {
                    aprov += 1;
                }
                else
                {
                    reprov += 1;
                }
            }
        }
        static void Main(string[] args)
        {
            int students;
            int data = 5;
            int aprov = 0, reprov = 0;

            var select = new ConsoleKey();
            string selected = "Empty";
            string[] option = new string[9];
            for (int i = 0; i < option.Length; i++)
            {
                option[i] = " ";
            }
            int key = -1;

            Console.Write("Nº de Alunos na Turma: ");
            students = int.Parse(Console.ReadLine());

            string[,] class_data = new string[students, data];
            float[] media_students = new float[students];

            System.Threading.Thread.Sleep(1000);

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n | School \n\n | Use [TAB] key to select option! \n");
                    Console.WriteLine(" | " + option[0] + " Adicionar Dados aos Alunos da Turma ");
                    Console.WriteLine(" | " + option[1] + " Ver Alunos da Turma ");
                    Console.WriteLine(" | " + option[2] + " Média de Idade dos Alunos ");
                    Console.WriteLine(" | " + option[3] + " Média da Turma ");
                    Console.WriteLine(" | " + option[4] + " Média da Disciplina ");
                    Console.WriteLine(" | " + option[5] + " Nota de um Aluno ");
                    Console.WriteLine(" | " + option[6] + " Melhor Média do Aluno ");
                    Console.WriteLine(" | " + option[7] + " Alunos Aprovados e Reprovados ");
                    Console.WriteLine(" | " + option[8] + " Sair do Programa ");

                    select = Console.ReadKey(true).Key;

                    if (select == ConsoleKey.Tab)
                    {
                        for (int i = 0; i < option.Length; i++)
                        {
                            option[i] = " ";
                        }
                        if (key == option.Length - 1)
                        {
                            key = -1;
                        }
                        key++;
                        option[key] = ">";
                    }

                    if (select == ConsoleKey.Enter)
                    {
                        if (key != -1)
                        {
                            selected = option[key];
                        }
                    }
                } while (select != ConsoleKey.Enter || selected == "Empty");

                if (selected == option[0])
                {
                    Console.Clear();
                    CarregarMatriz(class_data, students, data);
                }

                if (selected == option[1])
                {
                    Console.Clear();
                    ImprimirMatriz(class_data, students, data);
                    Console.ReadLine();
                }

                if (selected == option[2])
                {
                    Console.Clear();
                    Console.WriteLine("\n | Total de Alunos: " + students + "\n");
                    Console.WriteLine(" | Média de Idades: " + MediaIdade(class_data, students));
                    Console.ReadLine();
                }

                if (selected == option[3])
                {
                    Console.Clear();
                    Console.WriteLine("\n | Total de Alunos: " + students + "\n");
                    Console.WriteLine(" | Média da Turma: " + MediaTurma(class_data, students));
                    Console.ReadLine();
                }

                if (selected == option[4])
                {
                    Console.Clear();
                    MediaDisciplina(class_data, students);
                    Console.ReadLine();
                }

                if (selected == option[5])
                {
                    Console.Clear();
                    NotaAluno(class_data, students, media_students);
                    Console.ReadLine();
                }

                if (selected == option[6])
                {
                    Console.Clear();
                    Console.WriteLine("\n | Melhor Media: " + MelhorMediaAluno(students, media_students));
                    Console.ReadLine();
                }

                if (selected == option[7])
                {
                    Console.Clear();
                    AlunosAprovReprov(students, media_students, ref aprov, ref reprov);
                    Console.WriteLine("\n | Alunos Aprovados: " + aprov);
                    Console.WriteLine(" | Alunos Reprovados: " + reprov);
                    Console.ReadLine();
                }

            } while (selected != option[8]);
        }
    }
}
