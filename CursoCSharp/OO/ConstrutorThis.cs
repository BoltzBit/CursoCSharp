using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }
        
        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) 
        {
            Console.WriteLine($"{Nome} o cachorro");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura} de altura";
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var dog = new Cachorro("dog", 2.5);

            Console.WriteLine(spike);
            Console.WriteLine(dog.ToString());
        }
    }
}
