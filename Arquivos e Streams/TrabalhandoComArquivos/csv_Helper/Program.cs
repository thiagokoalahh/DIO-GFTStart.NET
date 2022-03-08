using csv_Helper.Mapping;
using csv_Helper.Model;
using System.Globalization;

namespace csv_Helper
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LerCsvDynamic();
            //LerCsvComClasse();
            //LerCsvComOutroDelimitador();
            EscreverCsv();

            Console.WriteLine("Digite enter para finalizar...");
            Console.ReadKey();

        }


        static void EscreverCsv()
        {
            var projectPath = Path.Combine(Environment.CurrentDirectory).Replace(@"bin\Debug\net6.0", "");
            var path = Path.Combine(projectPath, "Saida");

            var di = new DirectoryInfo(path);
            if (!di.Exists)
                di.Create();

            path = Path.Combine(path, "usuarios.csv");

            var pessoas = new List<Pessoa>()
            {
                new Pessoa()
                {
                    Nome = "José da Silva",
                    Email = "js@gmail.com",
                    Telefone = 123456,
                },
                new Pessoa()
                {
                    Nome = "Pedro Paiva",
                    Email = "pp@gmail.com",
                    Telefone = 456789,
                },
                new Pessoa()
                {
                    Nome = "Maria Antonia",
                    Email = "ma@gmail.com",
                    Telefone = 123456,
                },
                new Pessoa()
                {
                    Nome = "Carla Moraes",
                    Email = "cms@gmail.com",
                    Telefone = 9987411,

                },
            };

            using var sw = new StreamWriter(path);
            var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = "|"
            };

            using var csvWriter = new CsvHelper.CsvWriter(sw, csvConfig);
            csvWriter.WriteRecords(pessoas);
        }

        static void LerCsvComOutroDelimitador()
        {
            var projectPath = Path.Combine(Environment.CurrentDirectory).Replace(@"bin\Debug\net6.0", "");
            var path = Path.Combine(projectPath, "Entrada", "Livros-preco-com-virgula.csv");

            var fi = new FileInfo(path);
            if (!fi.Exists)
                throw new FileNotFoundException($"O arquivo {path} não existe!");

            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };

            using var csvReader = new CsvHelper.CsvReader(sr, csvConfig);
            csvReader.Context.RegisterClassMap<LivroMap>();

            var registros = csvReader.GetRecords<Livro>().ToList();

            foreach (var registro in registros)
            {
                Console.WriteLine($"Titulo:{registro.Titulo}");
                Console.WriteLine($"Preco:{registro.Preco}");
                Console.WriteLine($"Autor:{registro.Autor}");
                Console.WriteLine($"Lançamento:{registro.Lancamento}");
                Console.WriteLine("----------------");
            }
        }

        static void LerCsvComClasse()
        {
            var projectPath = Path.Combine(Environment.CurrentDirectory).Replace(@"bin\Debug\net6.0", "");
            var path = Path.Combine(projectPath, "Entrada", "novos-usuarios.csv");

            var fi = new FileInfo(path);
            if (!fi.Exists)
                throw new FileNotFoundException($"O arquivo {path} não existe!");

            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture);
            using var csvReader = new CsvHelper.CsvReader(sr, csvConfig);

            var registros = csvReader.GetRecords<Usuario>();

            foreach (var registro in registros)
            {
                Console.WriteLine($"Nome:{registro.Nome}");
                Console.WriteLine($"Email:{registro.Email}");
                Console.WriteLine($"Telefone:{registro.Telefone}");
                Console.WriteLine("----------------");
            }

        }

        static void LerCsvDynamic()
        {
            var projectPath = Path.Combine(Environment.CurrentDirectory).Replace(@"bin\Debug\net6.0", "");
            var path = Path.Combine(projectPath, "Entrada", "Produtos.csv");

            var fi = new FileInfo(path);
            if (!fi.Exists)
                throw new FileNotFoundException($"O arquivo {path} não existe!");

            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture);
            using var csvReader = new CsvHelper.CsvReader(sr, csvConfig);

            var registros = csvReader.GetRecords<dynamic>();

            foreach (var registro in registros)
            {
                Console.WriteLine($"nome:{registro.Produto}");
                Console.WriteLine($"marca:{registro.Marca}");
                Console.WriteLine($"preco:{registro.Preco}");
                Console.WriteLine("----------------");
            }
        }
    }
}
