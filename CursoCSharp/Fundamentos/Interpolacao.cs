using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("nome: " + nome + " marca: " + marca + " preco: " + preco);
            //outra forma de mostrar essa string
            //os numeros em colchetes são substituidos pelas variaveis
            Console.WriteLine("nome: {0}, marca: {1}, preco: {2}",nome,marca,preco);

            //outra forma
            Console.WriteLine($"A marca {marca} é boa e 1+1 = {1+1}");
        }
    }
}
