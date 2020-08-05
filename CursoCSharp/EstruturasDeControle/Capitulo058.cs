using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class Capitulo058
    {
        public static void Executar()
        {
            int temp;

            for (int i = 1;i <= 10;i++)
            {
                for (int j = 1;j <= i;j++)
                {
                    temp = i * j;
                    Console.Write($" {temp} ");
                }
                Console.WriteLine();
            }
        }
    }
}
