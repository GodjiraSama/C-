using System;

namespace RetaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(6, 9);
            Ponto p2 = p1;
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Reta r1 = new Reta(p1, p2);
            Console.WriteLine(r1.ToString());
        }
    }
}
