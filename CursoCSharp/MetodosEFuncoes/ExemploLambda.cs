using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () => 
            {
                Console.WriteLine("Exemplo funcao lambda");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();

                return random.Next(1,7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");

            Console.WriteLine(conversorHex(8));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
               {
                   return String.Format("{0:D2}/{1:D2}/{2:D4}",dia,mes,ano);
               };

            Console.WriteLine(formatarData(20,2,2020));
        }
    }
}
