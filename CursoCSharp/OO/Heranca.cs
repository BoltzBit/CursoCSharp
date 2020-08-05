using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        public int VelocidadeMaxima { get; protected set; }

        public int VelocidadeAtual { get; protected set; }

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        //adicionar virtual significa que o metodo pode ser sobreescrito pelas classes filhas
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public virtual int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        //chamando o construtor base, na classe carro que é pai, e passando o valor padrao para a classe Uno
        public Uno() : base(200) { }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350) { }

        //sobreescrever os metodos acelerar e frear
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        public override int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno uno = new Uno();
            int i = 1;
            int j = 1;

            while (i <= 200)
            {
                uno.Acelerar();
                i *= 5;
            }

            Console.WriteLine("Velocidade Uno: {0}", uno.VelocidadeAtual);

            Console.WriteLine("Ferrrari..");

            Ferrari ferrari = new Ferrari();

            while (j <= 350)
            {
                ferrari.Acelerar();
                j *= 5;
            }

            Console.WriteLine("Velocidade Ferrari: {0}", ferrari.VelocidadeAtual);

            //exemplos de polimorfismo
            Carro carro3 = new Uno();
            Carro carro4 = new Ferrari();

            carro3 = new Uno();
        }
    }
}
