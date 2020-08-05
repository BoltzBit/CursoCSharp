using System;
using System.IO;

namespace CursoCSharp.Api
{
    class UsandoPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path.txt".ParseHome();
            var pasta = @"~/exemplo_path".ParseHome();

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = new StreamWriter(arquivo))
                {
                    sw.WriteLine("Este é um novo arquivo");
                }
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));


            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));
        }
    }
}
