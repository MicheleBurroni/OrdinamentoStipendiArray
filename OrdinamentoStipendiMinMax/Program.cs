using System;
using Operazioni;
     
namespace OrdinamentoStipendiMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci gli stipendi:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Gestione.RiempimentoArray(array);
            Gestione.BubbleSort(array);
            Console.WriteLine($"Stipendio minimo: {array[0]}.");
            Console.WriteLine($"Stipendio massimo:{array[array.Length - 1]}.");
            Gestione.StampaArray(array);
        }
    }
}
