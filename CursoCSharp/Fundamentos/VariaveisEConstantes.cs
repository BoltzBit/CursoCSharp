using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Variaveis e constantes
            //area da circunferencia
            double raio = 4.5;
            //quando tem const, não pode ser alterado
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;

            //tipos internos

            bool estaChovendo = true;

            byte idade = 45;

            sbyte saldoDeGols = sbyte.MinValue;

            short salario = short.MaxValue;

            int menorInt = int.MinValue;

            long menorLong = long.MinValue;

            float precoComp = 12666.78f;

            decimal maxDec = decimal.MaxValue;

            //para caractere unico, usar aspas simples
            char letra = 'b';

            //para string, usar aspas duplas
            string frase = "armazenar uma string";

            Console.WriteLine(raio);
            Console.WriteLine(area);
            Console.WriteLine("Está chovendo? " + estaChovendo);
            Console.WriteLine("idade: " + idade);
            Console.WriteLine(saldoDeGols);
            Console.WriteLine(salario);
            Console.WriteLine(menorInt);
            Console.WriteLine(menorLong);
            Console.WriteLine(precoComp);
            Console.WriteLine(maxDec);
            Console.WriteLine(letra);
            Console.WriteLine(frase);
        }
    }
}
