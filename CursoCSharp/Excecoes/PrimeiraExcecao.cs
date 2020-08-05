using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        private double Saldo { get; set; }

        public Conta() { }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo || valor < 0)
            {
                throw new ArgumentException("Saldo Insuficiente");
            }

            Saldo -= valor;
        }

    }

    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(366.25);

            try
            {
                conta.Sacar(16000);
                Console.WriteLine("Saque realizado com sucesso");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
