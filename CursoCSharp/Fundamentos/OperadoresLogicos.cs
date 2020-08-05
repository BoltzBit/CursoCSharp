using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            //Operadores logicos, &&, ||, ^
            var executou = true;
            var nexecutou = false;
            //o ou exclusivo é verdadeiro quando as duas portas são diferentes (true, false)
            var comprou = executou ^ nexecutou;

            Console.WriteLine("teste: {0}", comprou);
        }
    }
}
