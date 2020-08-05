using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class Break
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            for (int i = 1;i<50;i++)
            {
                Console.WriteLine("{0} é o numero certo? ", i);

                if(numero == i)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }
        }
    }
}
