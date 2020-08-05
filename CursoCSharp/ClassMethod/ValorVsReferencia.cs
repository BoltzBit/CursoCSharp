using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class Dependente
    {
        public string Nome;
        public int Idade;
    }

    class ValorVsReferencia
    {

        public static void Executar()
        {
            int numero = 3;
            int copiaDoNumero = numero;
            Console.WriteLine($"{numero} {copiaDoNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaDoNumero}");

            Dependente dep = new Dependente() 
            {
                Nome = "Mateus",
                Idade = 26,
            };

            //classe passa copia por referencia
            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {dep.Idade}");
            Console.WriteLine($"{copiaDep.Nome} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            copiaDep.Idade = 28;

            Console.WriteLine($"{dep.Nome} {dep.Idade}");
            Console.WriteLine($"{copiaDep.Nome} {copiaDep.Idade}");
        }
    }
}
