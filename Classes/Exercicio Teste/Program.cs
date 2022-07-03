using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseRetangulo
{
    class Program
    {
        public class WierdSquare
        {
            private int largura;
            private int comprimento;
            private string cor;

            public WierdSquare()
            {
                largura = 0;
                comprimento = 0;
                cor = "preto";

            }

            public WierdSquare(int a, int b, string c)
            {
                do
                {
                    if (a < 5 || a > 20)
                    {
                        Console.WriteLine("O comprimento so pode ser entre 5 e 20, qual é o novo valor?\n");
                        a = int.Parse(Console.ReadLine());
                    }
                } while (a > 20 || a < 5);

                do
                {
                    if (b < 10 || b > 40)
                    {
                        Console.WriteLine("A Largura so pode ser entre 40 e 10, qual é o novo valor?\n");
                        b = int.Parse(Console.ReadLine());
                    }
                } while (b > 40 || b < 10);
                largura = a;
                comprimento = b;
                cor = c;
            }

            public void set(int a, int b, string c)
            {
                do
                {
                    if (a < 5 || a > 20)
                    {
                        Console.WriteLine("O comprimento so pode ser entre 5 e 20, qual é o novo valor?\n");
                        a = int.Parse(Console.ReadLine());
                    }
                } while (a > 20 || a < 5);
                largura = a;
                do
                {
                    if (b < 10 || b > 40)
                    {
                        Console.WriteLine("A Largura so pode ser entre 40 e 10, qual é o novo valor?\n");
                        b = int.Parse(Console.ReadLine());
                    }
                } while (b > 40 || b < 10);
                comprimento = b;
                cor = c;

            }
            public int getLargura()
            {
                return largura;
            }
            public int getComprimento()
            {
                return comprimento;
            }

            public string getCor()
            {
                return cor;
            }

            public override string ToString()
            {


                return "O retangulo tem " + largura + " de largura e " + comprimento + " de comprimento sendo que a cor é " + cor + ".";
            }

            public int Perimetro()
            {
                int perimetro;
                perimetro = (largura + comprimento) * 2;
                return perimetro;
            }
            public int Area()
            {
                int area;
                area = largura * comprimento;
                return area;
            }
            public bool CheckArea(int a)
            {
                if (a > (largura * comprimento))
                {
                    return true;
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            int n, largura, comprimento;
            string cor;
            Console.WriteLine("Quantos retangulos é que quer criar\n");
            n = int.Parse(Console.ReadLine());
            WierdSquare[] mat = new WierdSquare[n]; //criar uma array de objetos

            for (int i = 0; i < n; i++) //por cada iteraçao constroi um retangulo
            {
                Console.WriteLine("Qual vai ser a largura do seu " + (i + 1) + "º quadrado estranho?\n");
                largura = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual vai ser o comprimento do seu " + (i + 1) + "º quadrado estranho?\n");
                comprimento = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual é a cor do seu " + (i + 1) + "º quadrado estranho?\n");
                cor = Console.ReadLine();
                mat[i] = new WierdSquare(largura, comprimento, cor);
            }                                    //  _
            Console.WriteLine(mat[0].ToString()); //   |
            Console.WriteLine(mat[1].ToString()); //   |ja sabia que ia apenas construir 3
            Console.WriteLine(mat[2].ToString()); //  _|é só para testar
            Console.ReadKey();
            Console.Clear();
        }
    }
}

