using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversao
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            double nota = 9.7;
            int notaTruncada = (int) nota;

            Console.WriteLine(quebrado);
            Console.WriteLine(notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idade = Console.ReadLine();

            int idadeConvert = int.Parse(idade);

            Console.WriteLine("idade: {0}",idadeConvert);

            Console.WriteLine("Digite um numero: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);

            Console.WriteLine("Resultado: {0}",numero);

        }
    }
}
