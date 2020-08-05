using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 2)
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(3, 2));
            Console.WriteLine(Somar(4,5));
        }
    }
}
