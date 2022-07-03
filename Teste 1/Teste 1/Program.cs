using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declaração de variáveis
			string n1, n2 ;
			int soma;

			//Leitura dos valores
			Console.WriteLine("Digite o primeiro número:");
			n1 = Console.ReadLine();
			Console.WriteLine("Digite o segundo número:");
			n2 = Console.ReadLine();

			//Calcular soma
			soma = int.Parse(n1) + int.Parse(n2);

			//Apresentar o resultado
			Console.WriteLine("Soma: " + soma);

			//Esperar 3 segundos
			System.Threading.Thread.Sleep(3000);
		}
	}
}
