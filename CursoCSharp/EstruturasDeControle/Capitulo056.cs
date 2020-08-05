using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class Capitulo056
    {
        public static void Executar()
        {
            //fatorial de 1 a 10
            int fat = 1;
            int n = 1;

            for (int i = 0;i<=10;i++)
            {

                if (i == 0 || i == 1)
                {
                    Console.WriteLine("Fatorial de {0}: 1",i);
                    continue;
                }
                
                while (n<=i)
                {
                    fat = fat*n;
                    n++;
                }

                Console.WriteLine("Fatorial de {0}: {1}",i,fat);
            }
        }
    }
}
