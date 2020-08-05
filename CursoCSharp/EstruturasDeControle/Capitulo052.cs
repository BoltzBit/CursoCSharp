using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class Capitulo052
    {
        public static void Executar()
        {
            int soma = 1;

            for (int i = 0; i<1000;i++)
            {
                soma+=i;
            }

            Console.WriteLine(soma);
        }
    }
}
