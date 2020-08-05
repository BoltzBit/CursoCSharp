using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{

    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto() { }
    }

    class List
    {
        public static void Executar()
        {
            var livro = new Produto("IT", 55.2);
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa",29.9),
                new Produto("Tenis", 12.3),
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach(var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }


        }
    }
}
