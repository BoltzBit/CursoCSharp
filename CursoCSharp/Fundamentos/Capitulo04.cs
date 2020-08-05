using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Capitulo04
    {
        public static void Executar()
        {
            //double saldo = 500.0;
            //double saqueValor = 10.0;

            //if (saldo >= saqueValor)
            //{
            //    saldo -= saqueValor;
            //    Console.WriteLine("Saque realizado com sucesso!");
            //    Console.WriteLine("Saldo: " + saldo);
            //}
            //else
            //{
            //    Console.WriteLine("Saldo insuficiente!");
            //    Console.WriteLine("Saldo: " + saldo);
            //}

            //if (saldo < 1000)
            //{
            //    saldo = saldo * 0.99;
            //    Console.WriteLine("Saldo: " + saldo);
            //}
            //else if (saldo >= 1000 && saldo <= 5000)
            //{
            //    saldo = saldo * 0.95;
            //    Console.WriteLine("Saldo: " + saldo);
            //}
            //else
            //{
            //    saldo = saldo * 0.90;
            //    Console.WriteLine("Saldo: " + saldo);
            //}

            //if (saldo < 0.0)
            //{
            //    Console.WriteLine("Voce está no negativo");
            //}
            //else if (saldo < 100000.0)
            //{
            //    Console.WriteLine("Voce é um bom cliente");
            //}
            //else
            //{
            //    Console.WriteLine("Você é milionario!");
            //}

            //int idade = 18;
            //bool brasileira = false;

            //if(idade>=16 && brasileira)
            //{
            //    Console.WriteLine("Está apta a votar");
            //}
            //else
            //{
            //    Console.WriteLine("Não está apta a votar");
            //}

            //imposto <= 999 = 2%
            //imposto de 1000 à 2999 = 2,5%
            //imposto de 3000 à 6999 = 2.8%
            //imposto >= 7000 = 3%

            //double valorDaNotaFiscal = 4000.00;
            //double imposto;

            //if (valorDaNotaFiscal <= 999.00) {

            //    imposto = valorDaNotaFiscal * 0.02;

            //}else if (valorDaNotaFiscal>=1000 && valorDaNotaFiscal<3000)
            //{
            //    imposto = valorDaNotaFiscal * 0.025;

            //}else if (valorDaNotaFiscal>=3000 && valorDaNotaFiscal < 7000)
            //{
            //    imposto = valorDaNotaFiscal * 0.028;
            //}
            //else
            //{
            //    imposto = valorDaNotaFiscal * 0.03;
            //}

            //Console.WriteLine($"Imposto: {imposto}");

            int valor = 9;
            string mensagem = "";

            if(valor > 10)
            {
                mensagem = "Valor maior que Dez";
                Console.WriteLine(mensagem);
                return;
            }

            mensagem = "Valor menor que Dez";
            Console.WriteLine(mensagem);
        }
    }
}
