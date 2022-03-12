using System;
using System.Collections.Generic;
using System.Linq;

class MinhaClasse
{
    public static void Main(string[] args)
    {
        var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalDeCasosDeTeste; i++)
        {
            string[] compras = Console.ReadLine().TrimEnd(' ').Split(" ");
            var comprasFiltrada = compras.Distinct().OrderBy(item => item);

            Console.WriteLine(string.Join(" ", comprasFiltrada));
        }
    }
}