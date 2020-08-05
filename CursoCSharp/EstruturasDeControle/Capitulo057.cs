using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class Capitulo057
    {
        public static void Executar()
        {
            //Sequencia Fibonacci
            //0 1 1 2 3 5 8 13 21...
            int proximo = 0;
            int anterior = 0;
            int atual = 1;

            Console.WriteLine(proximo);

            do
            {
                anterior = atual;
                atual = proximo;

                Console.WriteLine(proximo);

                proximo = atual + anterior;

            } while (proximo <= 100);
        }
    }
}
