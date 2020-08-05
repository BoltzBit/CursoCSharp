using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Mateus";
            sicrano.Idade = 26;

            //Console.WriteLine("{0} tem {1}",sicrano.Nome,sicrano.Idade);

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoFulano = fulano.Apresentar();

            Console.WriteLine(apresentacaoFulano);
        }
    }
}
