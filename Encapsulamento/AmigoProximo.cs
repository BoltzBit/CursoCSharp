using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amigo.InfoPublic);
            // Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.JeitoDeFalar);
            // Console.WriteLine(amiga.SegredoFamilia);
            // Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
}
