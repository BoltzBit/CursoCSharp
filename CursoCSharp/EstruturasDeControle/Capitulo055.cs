using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class Capitulo055
    {
        public static void Executar()
        {
            //imprima somente divisiveis por 3 ou 4
            for (int i = 1;i<=30;i++)
            {
                if (i%3 == 0 || i%4 == 0)
                {
                    Console.WriteLine("Numero: {0}", i);
                }
            }
        }
    }
}
