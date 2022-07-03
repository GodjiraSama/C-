using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            float div = 0;

            do
            {
                Console.Clear();

                try
                {
                    Console.Write("1º Número: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("2º Número: ");
                    num2 = int.Parse(Console.ReadLine());

                    div = num1 / num2;
                }
                catch (DivideByZeroException except)
                {
                    Console.WriteLine("Exception: " + except.Message);
                    System.Threading.Thread.Sleep(3000);
                }
                catch (FormatException except)
                {
                    Console.WriteLine("Exception: " + except.Message);
                    System.Threading.Thread.Sleep(3000);
                }
            } while (div == 0);

            Console.WriteLine("Divisão: " + div);

            Console.ReadLine();
        }
    }
}
