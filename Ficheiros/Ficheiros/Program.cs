using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficheiros
{
    class Program
    {
        static void Main(string[] args)
{
            StreamReader rd = new StreamReader(@"fichaRead.txt");
            StreamWriter wr = new StreamWriter(@"fichaWrite.txt", true);

            while(!rd.EndOfStream)
            {
              string linha = rd.ReadLine();
              wr.WriteLine(linha);
            }
            wr.Close();
            rd.Close();
            System.Threading.Thread.Sleep(3000);
        }
    }
}
