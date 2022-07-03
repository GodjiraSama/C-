using System;

namespace ex2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] data = { 1.5f, 0.7f, 8.0f };
            float minimum = 0, maximum = 0;
            MaxMinArray(data, ref minimum, ref maximum);
            Console.WriteLine($"O valor minimo é {minimum} e o máximo é {maximum}");
            Console.ReadKey();
        }
        public static void MaxMinArray(float[] data, ref float minimum, ref float maximum)
        {
            minimum = data[0];
            maximum = data[0];

            for(int i=0; i<3;i++)
            {
                if (data[i]>maximum)
                {
                    maximum = data[i];
                }
                else if (data[i]<minimum)
                {
                    minimum = data[i];
                }
            }
        }
    }
}
