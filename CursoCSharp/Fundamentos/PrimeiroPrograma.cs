using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class PrimeiroPrograma
    {
        public static void Executar()
        {
            int a=3, b=-7, c=4;
            double delta, a1, a2;

            delta = b*b - 4 * a * c;

            a1 = (-b + Math.Sqrt(delta)) / 2 * a;
            a2 = (-b-Math.Sqrt(delta)) / 2 * a;

            Console.WriteLine("a1 = " + a1);
            Console.WriteLine("a2 = " + a2);

            //double idademateus = 3.14;
            //int idadegustavo = (int)idademateus;

            //var idadesomada = idademateus + idadegustavo;

            //Console.WriteLine("idade somada " + idadegustavo);
        }
    }
}
