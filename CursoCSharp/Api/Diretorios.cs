using System;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/ParseCSharp".ParseHome();
            var novoDirDestino = @"~/ParseCSharpDestino".ParseHome();
            var dirCurso = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("Pastas----------------");

            foreach (var diretorio in Directory.GetDirectories(dirCurso))
            {
                Console.WriteLine(diretorio);
            }

            Console.WriteLine("Arquivos ------------");
            foreach (var arquivo in Directory.GetFiles(dirCurso))
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\nRaiz------------");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
