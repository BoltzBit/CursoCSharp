using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoValores
    {
        public static void Executar()
        {
            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu salário? ");
            //ao passar o segundo parametro de cultura sem variação, podemos usar a notação ponto em vez de virgula, no console
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"nome: {nome}, idade: {idade}, salario: {salario}");
        }
    }
}
