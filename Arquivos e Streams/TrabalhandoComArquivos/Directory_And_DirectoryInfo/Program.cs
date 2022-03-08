using System;
using System.IO;

namespace Directory_And_DirectoryInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CriarDiretoriosGlobo();
            //CriarArquivo();

            //var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
            //var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Argentina", "argentina.txt");
            //MoverArquivo(origem, destino);
            //CopiarArquivo(origem, destino);

            var path = Path.Combine(Environment.CurrentDirectory, "globo");
            //LerDiretorios(path);
            LerArquivos(path);
        }

        static void LerArquivos(string path)
        {
            var arquivos = Directory.GetFiles(path,"*",SearchOption.AllDirectories);
            foreach (var arquivo in arquivos)
            {
                var fileInfo = new FileInfo(arquivo);
                Console.WriteLine($"[Nome]: {fileInfo.Name}");
                Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
                Console.WriteLine($"[Ultimo Acesso]: {fileInfo.LastAccessTime}");
                Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}");
            }
        }
        static void LerDiretorios(string path)
        {
            if (Directory.Exists(path))
            {
                var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
                foreach (var dir in diretorios)
                {
                    var dirInfo = new DirectoryInfo(dir);
                    Console.WriteLine($"[Nome]:{dirInfo.Name}");
                    Console.WriteLine($"[Raiz]:{dirInfo.Root}");
                    if (dirInfo.Parent != null)
                        Console.WriteLine($"[Pai]:{dirInfo.Parent.Name}");

                    Console.WriteLine("-------------------");
                }
            }
            else
            {
                Console.WriteLine($"{path} não existe");
            }
        }
        static void CopiarArquivo(string pathOrigem, string pathDestino)
        {
            if (!File.Exists(pathOrigem))
            {
                Console.WriteLine("Arquivo de origem não existe");
                return;
            }

            if (File.Exists(pathDestino))
            {
                Console.WriteLine("Arquivo já existe na pasta de destino");
                return;
            }

            File.Copy(pathOrigem, pathDestino);
        }
        static void MoverArquivo(string pathOrigem, string pathDestino)
        {
            if (!File.Exists(pathOrigem))
            {
                Console.WriteLine("Arquivo de origem não existe");
                return;
            }

            if (File.Exists(pathDestino))
            {
                Console.WriteLine("Arquivo já existe na pasta de destino");
                return;
            }

            File.Move(pathOrigem, pathDestino);
            
        }
        static void CriarArquivo()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
            if (!File.Exists(path))
            {
                using var sw = File.CreateText(path);
                sw.WriteLine("População: 213MM");
                sw.WriteLine("IDH: 0,901");
                sw.WriteLine("Dados atualizados em: 20/04/2018");
            }
        }
        static void CriarDiretoriosGlobo()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "globo");
            if (!Directory.Exists(path))
            {
                var dirGlobo = Directory.CreateDirectory(path);

                var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
                var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
                var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

                dirAmNorte.CreateSubdirectory("USA");
                dirAmNorte.CreateSubdirectory("Mexico");
                dirAmNorte.CreateSubdirectory("Canadá");

                dirAmCentral.CreateSubdirectory("Costa Rica");
                dirAmCentral.CreateSubdirectory("Panama");

                dirAmSul.CreateSubdirectory("Brasil");
                dirAmSul.CreateSubdirectory("Argentina");
                dirAmSul.CreateSubdirectory("Paraguai");
            }
        }
    }
}
