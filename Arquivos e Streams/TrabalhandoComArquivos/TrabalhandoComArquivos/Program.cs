using System;
using System.IO;

namespace FIle_And_FileInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do arquivo:");
            var nome = Console.ReadLine();

            nome = LimparNome(nome);

            var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

            CriarArquivo(path);

            Console.WriteLine("Digite enter para finalizar");
            Console.ReadLine();
        }

        static string LimparNome(string nome)
        {
            foreach (var @char in Path.GetInvalidFileNameChars())
            {
                nome = nome.Replace(@char, '-');
            }
            return nome;
        }

        static void CriarArquivo(string path)
        {
            try
            {
                using var sw = File.CreateText(path);
                sw.WriteLine("Esta é a linha 1 do arquivo");
                sw.WriteLine("Esta é a linha 2 do arquivo");
                sw.WriteLine("Esta é a linha 3 do arquivo");
            }
            catch
            {
                Console.WriteLine("Nome do arquivo está inválido");
            }
        }
    }
}
