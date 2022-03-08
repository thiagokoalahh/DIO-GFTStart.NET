using System;
using System.IO;
using System.Text;

namespace String_Reader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Caracteres na primeira linha para ler");
            sb.AppendLine("e a segunda linha");
            sb.AppendLine("e o fim");

            using var sr = new StringReader(sb.ToString());
            var buffer = new char[10];
            var tamanho = 0;


            do
            {
                Console.WriteLine(sr.ReadLine());
            } while (sr.Peek() >= 0);

            //do
            //{

            //    tamanho = sr.Read(buffer);
            //    Console.Write(string.Join("", buffer));
            //    buffer = new char[10];

            //} while (tamanho >= buffer.Length);

            Console.WriteLine("Digite [enter] para finalizar....");
            Console.ReadKey();
        }
    }
}
