using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2_2
{
    class Program
    {
        public static void CountVogais(string str, out int vogais)
        {
            int vogUpper = str.Count(x => (x == 'A') || (x == 'E') || (x == 'I') || (x == 'O') || (x == 'U'));
            int vogLower = str.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));
            vogais = vogUpper + vogLower;
        }
        static void Main(string[] args)
        {
            string str;
            int vogais;

            Console.WriteLine("Insira uma String: ");
            str = Console.ReadLine();

            CountVogais(str, out vogais);

            Console.WriteLine("String: " + str);
            Console.WriteLine("Vogais: " + vogais);

            Console.ReadLine();
        }
    }
}