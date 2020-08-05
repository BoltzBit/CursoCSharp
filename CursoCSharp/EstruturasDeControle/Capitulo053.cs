using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class Capitulo053
    {
        public static void Executar()
        {
            //multiplos de 3 entre 1 e 100
            for (int i=1;i<=100;i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine("{0} é multiplo de 3",i);
                }
            }
        }
    }
}
