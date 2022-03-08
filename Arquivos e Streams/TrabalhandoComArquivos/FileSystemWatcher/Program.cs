using System;
using System.IO;

namespace FileSystem_Watcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "globo");
            Console.WriteLine(path);
            using var fsw = new FileSystemWatcher(path);
            fsw.Created += OnCreated;
            fsw.Deleted += OnDeleted;
            fsw.Renamed += OnRenamed;

            fsw.EnableRaisingEvents = true;
            fsw.IncludeSubdirectories = true;

            Console.WriteLine($"Monitorando eventos na pasta {path}");
            Console.WriteLine("Pressione enter para finalizar.....");
            Console.ReadLine();
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Foi criado o arquivo {e.Name}");
        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Foi excluído o arquivo {e.Name}");
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
        }

    }
}
