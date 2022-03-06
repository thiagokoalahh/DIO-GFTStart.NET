using System;

namespace RefStruct
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Thiago";
            p1.Idade = 30;
            p1.EnderecoPessoa = new Endereco()
            {
                Logradouro = "Rua teste",
                Numero = 300,
                CEP = "000000",
                Cidade = "Guarapari"
            };

            Console.WriteLine("Fim");
        }
    }
}
