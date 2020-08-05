using System;
using System.IO;
using System.Net.Http.Headers;

namespace CursoCSharp.Api
{
    class DiretorioInfo
    {
        public static void Executar()
        {
            var direCurso = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();
            var directInfo = new DirectoryInfo(direCurso);

            if (!directInfo.Exists)
            {
                directInfo.Create();
            }

            Console.WriteLine("Arquivos==================");
            foreach (var arquivo in directInfo.GetFiles())
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("Diretorio=================");
            foreach (var diretorio in directInfo.GetDirectories())
            {
                Console.WriteLine(diretorio);
            }


            Console.WriteLine(directInfo.CreationTime);
            Console.WriteLine(directInfo.FullName);
            Console.WriteLine(directInfo.Root);
            Console.WriteLine(directInfo.Parent.Parent);
        }
    }
}
