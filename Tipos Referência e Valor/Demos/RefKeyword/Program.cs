using System;

namespace RefKeyword
{
    public class Program
    {
        static void Demo2()
        {
            var nomes = new string[] { "Thiago", "Ricardo", "José", "Fabiana", "Alice" };

            Console.WriteLine($@"A lista de nomes é:
                {string.Join(",\n", nomes)}
            ");

            Console.WriteLine("Digite o nome a ser substituido:");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o nome novo:");
            var nomeNovo = Console.ReadLine();

            AlterarNome(nomes, nome, nomeNovo);

            Console.WriteLine($@"A lista de nomes alterada é:
                {string.Join(",\n", nomes)}
            ");
        }

        static void Demo1()
        {
            int a = 5;

            Adicionar20(ref a);

            Console.WriteLine($"O valor de a é: {a}");
        }

        static void Adicionar20(ref int n)
        {
            n += 20;
        }

        static void AlterarNome(string[] nomes, string nome, string nomeNovo)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;
                }
            }
        }

        static ref string LocalizarNome(string[] nomes, string nome)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if(nomes[i] == nome)
                    return ref nomes[i];
            }
            throw new Exception("Nome não encontrado");
        }

        static void Main(string[] args)
        {
            var nomes = new string[] { "Thiago", "Ricardo", "José", "Fabiana", "Alice" };

            Console.WriteLine($@"A lista de nomes é:
                {string.Join(",\n", nomes)}
            ");

            Console.WriteLine("Digite o nome a ser substituido:");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o nome novo:");
            var nomeNovo = Console.ReadLine();

            ref var nomeAchado = ref LocalizarNome(nomes, nome);

            if(!string.IsNullOrWhiteSpace(nomeAchado))
            {
                nomeAchado = nomeNovo;

                Console.WriteLine($@"A lista de nomes alterada é:
                    {string.Join(",\n", nomes)}
                ");
            }
            else
            {
                Console.WriteLine("Nome não encontrado");
            }

        }
    }
}
