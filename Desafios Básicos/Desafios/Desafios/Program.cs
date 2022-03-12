using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nota, quociente, resto;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;

            int[] notas = new int[] {100, 50, 20, 10, 5, 2, 1};

            for (int i = 0; i < notas.Length; i++)
            {
                nota = notas[i];
                quociente = resto / notas[i];
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                resto = resto % notas[i];
            }

        }
    }
}