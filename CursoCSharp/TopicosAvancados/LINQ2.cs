using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno("Mateus",25,6.5),
                new Aluno("Gustavo",26,8.5),
                new Aluno("Jonas",46,8.9),
                new Aluno("Jhone",26,7.5),
                new Aluno("Victor",27,9.8)
            };

            var gustavo = alunos.Single(a => a.Nome.Equals("Gustavo"));
            Console.WriteLine($"{gustavo.Nome} {gustavo.Nota}");

            var fulano = alunos.SingleOrDefault(a => a.Nome.Equals("fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Nome inválido");
            }

            var jonas = alunos.First(a => a.Nome.Equals("Jonas"));
            Console.WriteLine($"{jonas.Nome}");

            var sicrano = alunos.FirstOrDefault(a => a.Nome.Equals("sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno inexistente");
            }

            var outroJonas = alunos.LastOrDefault(a => a.Nome.Equals("Jonas"));
            Console.WriteLine($"{outroJonas.Nome}");

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine($"{item.Nome}");
            }

            var maiorNota = alunos.Max(a => a.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(a => a.Nota);
            Console.WriteLine(menorNota);

            var soma = alunos.Sum(a => a.Nota);
            Console.WriteLine(soma);

            var media = alunos.Average(a => a.Nota);
            Console.WriteLine(media);
        }
    }
}
