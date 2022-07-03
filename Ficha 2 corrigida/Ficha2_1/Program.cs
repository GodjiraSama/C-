using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2_1
{
    class Program
    {
        public static void MinMaxArray(float[] data, ref float minimum, ref float maximum)
        {
            for(int i = 0; i < data.Length-1; i++)
            {
                if (data[i] < data[i+1])
                {
                    minimum = data[i];
                }
                else
                {
                    minimum = data[i + 1];
                }

                if (data[i] > data[i + 1])
                {
                    maximum = data[i];
                }
                else
                {
                    maximum = data[i + 1];
                }
            }
        }
        static void Main(string[] args)
        {
            float[] data = { 1.5f, 0.7f, 8.0f };
            float minimum = 0, maximum = 0;

            MinMaxArray(data, ref minimum, ref maximum);

            Console.WriteLine("Minimum: " + minimum);
            Console.WriteLine("Maximum: " + maximum);

            Console.ReadLine();
        }
    }
}
