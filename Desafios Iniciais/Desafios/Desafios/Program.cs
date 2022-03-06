using System;

public class Problem
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());

        while (x > 0)
        {
            if (x % 2 != 0)
                x++;

            int soma = 0;

            for (int i = 0; i < 5; i++)
            {
                soma += x;
                x += 2;
            }

            Console.WriteLine(soma);
            x = int.Parse(Console.ReadLine());
        }

    }

    static void DesafioMes()
    {

        int mes = int.Parse(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("February");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Digite um número válido de 1 a 12");
                break;
        }
        Console.ReadLine();
    }
    static void DesafioQuadradoCubo()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {

            int n1 = i;
            int n2 = n1 * n1;
            int n3 = n1 * n1 * n1;
            Console.WriteLine($"{n1} {n2} {n3}");

        }
    }
}