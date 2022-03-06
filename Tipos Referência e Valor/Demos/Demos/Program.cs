using System;
using System.Collections.Generic;

namespace Demos
{
    public class Program
    {
        static void Demo6()
        {
            int[] numeros = new int[] { 0, 2, 4, 6, 8 };
            Console.WriteLine("Digite o número que gostaria de encontrar");
            var numero = int.Parse(Console.ReadLine());

            int indiceEncontrado = EncontrarNumero(numeros, numero);

            if (indiceEncontrado >= 0)
                Console.WriteLine($"O número digitado está na posição: {indiceEncontrado}");
            else
                Console.WriteLine("O número digitado não foi encontrado.");
        }

        static void Demo5()
        {
            int[] pares = new int[] { 0, 2, 4, 6, 8 };

            MudarParaImpar(pares);

            Console.WriteLine($"Os ímpares {string.Join(",", pares)}");
        }

        static void Demo4()
        {
            string nome = "Thiago";

            TrocarNome(nome, "Thiago Araújo");

            Console.WriteLine($"O novo nome é: {nome}");
        }

        static void Demo3()
        {
            StructPessoa p1 = new StructPessoa()
            {
                Nome = "Thiago",
                Idade = 20,
                Documento = "1234"
            };

            var p2 = p1;

            p1 = TrocarNome(p1, "Thiago Santos");

            Console.WriteLine($@"
            Nome do p1: {p1.Nome}
            Nome do p2: {p2.Nome}
            ");
        }


        static void Demo2()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Thiago";
            p1.Idade = 20;
            p1.Documento = "1234";

            var p2 = p1.Clone();

            TrocarNome(p1, "Thiago Silva");

            Console.WriteLine($@"
            O nome de p1 é : {p1.Nome}
            O nome de p2 é : {p2.Nome}
            ");
        }

        static void Demo1()
        {
            int a = 2;
            a = Adicionar20(a);
            Console.WriteLine($"O valor da variável a é: {a}");
        }

        static int Adicionar20(int n)
        {
            return n += 20;
        }

        static void TrocarNome(Pessoa pessoa, string nomeNovo)
        {
            pessoa.Nome = nomeNovo;
        }

        static StructPessoa TrocarNome(StructPessoa structPessoa, string nomeNovo)
        {
            structPessoa.Nome = nomeNovo;
            return structPessoa;
        }

        static void TrocarNome(string nome, string nomeNovo)
        {
            nome = nomeNovo;
        }

        static void MudarParaImpar(int[] pares)
        {
            for (int i = 0; i < pares.Length; i++)
            {
                pares[i] += 1;
            }
        }

        static int EncontrarNumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                    return i;
            }
            return -1;
        }

        static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
        {
            foreach (var item in pessoas)
            {
                if (item.Nome == pessoa.Nome)
                    return true;
            }
            return false;
        }

        static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
        {
            foreach (var item in pessoas)
            {
                if (item.Equals(pessoa))
                    return true;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            List<StructPessoa> pessoas = new List<StructPessoa>()
            {
                new StructPessoa(){ Nome = "Thiago"},
                new StructPessoa(){ Nome = "Ricardo"},
                new StructPessoa(){ Nome = "José"},
                new StructPessoa(){ Nome = "Maria"},
                new StructPessoa(){ Nome = "Fabiana"},
            };

            Console.WriteLine("Digite a pessoa que gostaria de localizar");
            var nome = Console.ReadLine();

            var encontrado = EncontrarPessoa(pessoas, new StructPessoa() { Nome = nome });
            if (encontrado)
                Console.WriteLine("Pessoa localizada");
            else
                Console.WriteLine("Pessoa não localizada");
        }
    }
}
