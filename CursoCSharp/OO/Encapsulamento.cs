using System;
using System.Collections.Generic;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublic);
            Console.WriteLine(CorDoOlho);
            // Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            // Console.WriteLine(SegredoFamilia);
            // Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(amigo.InfoPublic);
            //Console.WriteLine(amigo.CorDoOlho);
            // Console.WriteLine(NumeroCelular);
            // Console.WriteLine(SegredoFamilia);
            // Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoProximo().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
