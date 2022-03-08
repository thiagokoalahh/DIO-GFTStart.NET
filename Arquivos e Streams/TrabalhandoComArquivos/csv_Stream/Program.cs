using System;
using System.IO;

namespace csv_Stream
{
    public class Program
    {
        static void Main(string[] args)
        {
            CriarCsv();
        }

        static void CriarCsv()
        {
            var projectPath = Path.Combine(Environment.CurrentDirectory).Replace(@"bin\Debug\net6.0", "");
            var path = Path.Combine(projectPath, "Saida");

            var pessoas = new List<Pessoa>(){
                new Pessoa()
                {
                    Nome = "José da Silva",
                    Email = "js@gmail.com",
                    Telefone = 123456,
                    Nascimento = new DateOnly(year: 1970, month: 2, day: 14)
                },
                new Pessoa(){
                    Nome = "Pedro Paiva",
                    Email = "pp@gmail.com",
                    Telefone = 456789,
                    Nascimento = new DateOnly(year: 2002, month: 4, day: 20)
                },
                new Pessoa()
                {
                    Nome = "Maria Antonia",
                    Email = "ma@gmail.com",
                    Telefone = 123456,
                    Nascimento = new DateOnly(year: 1982, month: 12, day: 4)
                },
                new Pessoa()
                {
                    Nome = "Carla Moraes",
                    Email = "cms@gmail.com",
                    Telefone = 9987411,
                    Nascimento = new DateOnly(year: 2000, month: 7, day: 20)
                }
            };


            var di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                di.Create();
                path = Path.Combine(path, "usuarios.csv");
            }
            using var sw = new StreamWriter(path);
            sw.WriteLine("nome,email,telefone,nascimento");
            foreach (var pessoa in pessoas)
            {
                var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
                sw.WriteLine(linha);
            }

        }


        static void LerCsv()
        {
            var projectPath = Path.Combine(Environment.CurrentDirectory).Replace(@"bin\Debug\net6.0", "");
            var path = Path.Combine(projectPath, "Entrada", "usuarios-exportacao.csv");
            if (File.Exists(path))
            {
                Console.WriteLine(path);
                using var sr = new StreamReader(path);

                var cabecalho = sr.ReadLine()?.Split(',');
                while (true)
                {
                    var registro = sr.ReadLine()?.Split(',');
                    if (registro == null) break;
                    if (cabecalho.Length != registro.Length)
                    {
                        Console.WriteLine("Arquivo fora do padrão");
                        break;
                    }

                    for (int i = 0; i < registro.Length; i++)
                    {
                        Console.WriteLine($"{cabecalho?[i]} : {registro[i]}");
                    }
                    Console.WriteLine("--------------");
                }
                Console.WriteLine("\n\nPressione [enter] para finalizar");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"O arquivo {path} não existe");
            }
        }

        class Pessoa
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public int Telefone { get; set; }
            public DateOnly Nascimento { get; set; }
        }
    }
}

