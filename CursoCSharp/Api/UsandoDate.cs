using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class UsandoDate
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2020, month: 8,day:20);

            Console.WriteLine(dateTime.Day);

            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            var diaAtual = DateTime.Today;
            Console.WriteLine(diaAtual);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd"));
        }
    }
}
