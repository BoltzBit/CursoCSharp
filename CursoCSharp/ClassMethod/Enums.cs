using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    public enum Genero { Acao,Aventura, Terror, Animacao, Comedia};

    public class Filme
    {
        public string Titulo;
        public Genero GeneroFilme;
    }

    class Enums
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmePraFamilia = new Filme();
            filmePraFamilia.Titulo = "Sharknado";
            filmePraFamilia.GeneroFilme = Genero.Comedia;

            Console.WriteLine("{0} {1}",filmePraFamilia.Titulo, filmePraFamilia.GeneroFilme);
        }
    }
}
