using System;

namespace Operazioni
{
    public class Gestione
    {
        public static void RiempimentoArray(double[] array)
        {
 
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Inserire gli stipendi in posizione {i}");
                
                array[i] = int.Parse(Console.ReadLine());
            }
        }
            public static double Max(double[] array)
        {
            double max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        public static double Min(double[] array)
        {
            double min = double.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        public static void BubbleSort(double[] array)
        {
            int x, j;
            double temp;
            for (x = 0; x < array.Length - x; x++)
            {
                for (j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public static void StampaArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
