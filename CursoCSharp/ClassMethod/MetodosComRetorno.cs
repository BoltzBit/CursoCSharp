using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Divisao(int a, int b)
        {
            return a / b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;
        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a)
        {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            CalculadoraComum calculadoraComum = new CalculadoraComum();

            var somar = calculadoraComum.Somar(3,5);
            var subtrair = calculadoraComum.Subtrair(6,2);
            var multiplicar = calculadoraComum.Multiplicar(6,8);
            var dividir = calculadoraComum.Divisao(9,3);

            Console.WriteLine("Soma: {0}", somar);
            Console.WriteLine("Subtração: {0}", subtrair);
            Console.WriteLine("Multiplicar: {0}", multiplicar);
            Console.WriteLine("Dividir: {0}", dividir);

            CalculadoraCadeia calculadoraCadeia = new CalculadoraCadeia();

            var total = calculadoraCadeia.Somar(2).Multiplicar(3).Subtrair(1).Multiplicar(4).Resultado();

            calculadoraCadeia.Imprimir();

            Console.WriteLine(total);
            calculadoraCadeia.Limpar();
            calculadoraCadeia.Somar(2);
            calculadoraCadeia.Imprimir();
        }
    }
}
