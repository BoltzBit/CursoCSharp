using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    //atributo pertence a classe e não a instancia, ou seja o atributo é estático, não pode mudar de acordo com a instancia
    class AtributosEstaticos
    {
        class Produto
        {
            public string Nome;
            public double Preco;
            public static double Desconto = 0.1;

            public Produto(string nome, double preco, double desconto)
            {
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
            }

            public Produto() { }

            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }
        }

        public static void Executar()
        {
            var produto1 = new Produto("Caderno", 5.65, 0.2);

            var produto2 = new Produto()
            {
                Nome = "Caderno",
                Preco = 6.52,
            };

            Produto.Desconto = 0.5;

            Console.WriteLine("Produto1: {0}",produto1.CalcularDesconto());
            Console.WriteLine("Produto2: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.05;

            Console.WriteLine("Produto1: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Produto2: {0}", produto2.CalcularDesconto());
        }
    }
}
