using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            var resultado = new DesafioAtributo();

            Console.WriteLine(resultado.a);
        }
    }
}
