using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublic = "Tenho instagram";

        //herança
        protected string CorDoOlho = "verde";

        //mesmo projeto (Assembly)
        internal ulong NumeroCelular = 36566565;

        //heranca ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        //mesma class ou herança no mesmo projeto
        private protected string SegredoDeFamilia = "Bla bla";

        //prvate é o padrao
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade");


            Console.WriteLine(InfoPublic);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
