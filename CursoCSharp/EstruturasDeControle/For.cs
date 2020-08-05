using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class For
    {
        public static void Executar()
        {
            double somatorio = 0;
            string entrada;
            string notaAluno;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 0;i<tamanhoTurma;i++)
            {
                Console.WriteLine("Informe a nota do aluno {0}", i+1);
                notaAluno = Console.ReadLine();
                double.TryParse(notaAluno, out double notaTurma);

                somatorio += notaTurma;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("media da turma: {0}", media);
        }
    }
}
