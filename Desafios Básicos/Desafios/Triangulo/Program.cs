using System;
using System.Globalization;

class minhaClasse
{
    static void Main(string[] args)
    {

        double a, b, c;
        string[] valor = Console.ReadLine().Split();

        a = Convert.ToDouble(valor[0], CultureInfo.InvariantCulture);
        b = Convert.ToDouble(valor[1], CultureInfo.InvariantCulture);
        c = Convert.ToDouble(valor[2], CultureInfo.InvariantCulture);

        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine($"Perimetro = {(a + b + c).ToString("0.0", CultureInfo.InvariantCulture)}");
        else
            Console.WriteLine($"Area = {((a + b) * c / 2).ToString("0.0", CultureInfo.InvariantCulture)}");
    }
}