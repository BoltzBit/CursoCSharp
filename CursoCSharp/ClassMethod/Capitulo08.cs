using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class Pearson
    {
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }

        //parametros obrigatorios vem antes de parametros opcionais nos construtores
        public Pearson(string rg, string nome = "sem nome" )
        {
            Nome = nome;
            Rg = rg;
        }
    }

    class Capitulo08
    {
        public static void Executar()
        {
            Pearson mateus = new Pearson("Mateus", "126598");
            Pearson mateus2 = new Pearson("Gustavo", "326598")
            {
                Cpf = "023659",
                Idade = 23,
            };

            Console.WriteLine(mateus.Nome);
            Console.WriteLine(mateus2.Idade);
        }
    }
}
