using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digie a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra");
            }else if (nota >= 7.0 && nota < 9.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("reprovado");
            }
        }
    }
}
