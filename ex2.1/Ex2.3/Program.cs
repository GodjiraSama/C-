using System;

namespace Ex2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0;
            int x2 = 0;
            bool flag = false;
            Console.WriteLine("Digite o valor:");
            do
            {
                try
                {
                    x1 = int.Parse(Console.ReadLine());
                    x2 = int.Parse(Console.ReadLine());
                    int result = (int)(x1 / x2);
                    Console.WriteLine(result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Divisão por zero não é permitida");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format Error!");
                    Console.WriteLine("Digite novamente");
                    flag = false;
                }
            } while (!flag);
        }
    }
}
