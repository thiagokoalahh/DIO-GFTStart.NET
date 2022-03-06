using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 1, 2, 3, 4, 5 };

            foreach(int numero in lista)
            {
                Console.WriteLine(numero);
            }

        }

        static void Exemplo1()
        {
            bool condicao = true;
            int valor;

            while (condicao)
            {
                Console.WriteLine("Digite um valor. 0 para sair.");
                valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                {
                    Console.WriteLine("Você saiu da aplicação");
                    condicao = false;
                }
                else
                {
                    Console.WriteLine("O valor informado é: " + valor);
                }
            }
        }
        static void Exemplo2()
        {
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = valor; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}