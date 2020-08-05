using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class DoWhile
    {
        public static void Executar()
        {
            string nome;
            string continuar;

            do
            {
                Console.WriteLine("Qual seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine($"Seja bem vindo {nome}");
                Console.WriteLine("Deseja continuar? (S/N)");
                continuar = Console.ReadLine();

            } while (continuar == "s");
        }
    }
}
