using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class Capitulo054
    {
        public static void Executar()
        {
            //somar numeros de 1 a 100 exceto multiplos de 3
            int soma = 0;

            for (int i = 1;i<=100;i++)
            {
                if(i%3 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
