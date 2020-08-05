using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class Continue
    {
        public static void Executar()
        {
            int intervalo = 50;

            Console.WriteLine("Numeros pares de 1 a {0}", intervalo);

            for(int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                Console.Write(i + " ");
            }
        }
    }
}
