using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class ParametrosNomeados
    {
        public static void FormatarData(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar()
        {
            FormatarData(ano: 2020, dia: 3, mes: 7);
            DateTime data = DateTime.Now;
            Console.WriteLine(data);
        }
    }
}
