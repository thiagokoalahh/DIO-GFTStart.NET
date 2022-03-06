using System;

namespace ComparandoValueEReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numero a = new Numero(2);
            Numero b = new Numero(2);

            if (a.N == b.N)
            {
                Console.WriteLine("a e b são iguais");
            }
            else
            {
                Console.WriteLine("a e b são diferentes");
            }
        }

        public class Numero
        {
            public int N { get; set; }

            public Numero(int n)
            {
                N = n;
            }

        }

    }
}
