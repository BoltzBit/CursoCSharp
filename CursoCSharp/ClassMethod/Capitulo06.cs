using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class Client
    {
        public string Nome;
        public string Cpf;
        public string Rg;
        public string Endereco;
        public int Idade;

        public bool MairDeIdade()
        {
            if (Idade > 18)
            {
                return true;
            }
            return false;
        }
    }

    class Conta
    {
        public int Numero;
        public double Saldo = 100;
        public Client Titular;

        Client maiorDeIdade = new Client();

        public bool Sacar(double valor)
        {
            if (maiorDeIdade.MairDeIdade())
            {
                if (Saldo >= valor && valor > 0)
                {
                    Saldo -= valor;
                    return true;
                }
            }

            Console.WriteLine("Menor de idade");
            return false;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Transferir(double valor, Conta destino)
        {
            if (Sacar(valor))
            {
                destino.Depositar(valor);
            }
        }
    }

    class Capitulo06
    {
        public static void Executar()
        {
            Conta conta = new Conta();//instancia -> objeto
            Conta victor = new Conta();

            Conta mauricio = new Conta();
            mauricio.Saldo = 2000.0;

            Conta guilherme = new Conta();
            guilherme.Saldo = 5000.0;

            mauricio.Saldo -= 200.0;
            guilherme.Saldo += 200.0;

            victor.Numero = 2;
           //victor.Titular = "Victor";

            conta.Numero = 1;
            //conta.Titular = "Mateus";
            conta.Saldo = 100;


            Conta marco1 = new Conta();
            marco1.Numero = 1;
            //marco1.Titular = "Marco";
            marco1.Saldo = 500.25;

            Conta marco2 = new Conta();
            marco2.Numero = 1;
            //marco2.Titular = "Marco";
            marco2.Saldo = 6532.00;

            Conta copiaMauricio = mauricio;

            if (marco1 == marco2)
            {
                Console.WriteLine("iguais");
            }
            else
            {
                Console.WriteLine("diferentes");
            }


            bool saque = conta.Sacar(10.5);

            if (saque)
            {
                Console.WriteLine("Deu certo");
            }
            else
            {
                Console.WriteLine("Não deu certo");
            }

            conta.Depositar(555.25);
            conta.Transferir(265.23, victor);

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(victor.Saldo);
            Console.WriteLine(guilherme.Saldo);
            Console.WriteLine(mauricio.Saldo);
            Console.WriteLine(mauricio.Saldo);
            Console.WriteLine(copiaMauricio.Saldo);

            Console.WriteLine("----------------------------");
            guilherme.Transferir(2562.00, victor);

            Conta gustavo = new Conta();
            Client clientGustavo = new Client();

            gustavo.Titular = clientGustavo;

            Client mateus = new Client();
            mateus.Nome = "Mateus";
            mateus.Rg = "32658";

            Conta contaMateus = new Conta();
            contaMateus.Titular = mateus;
            contaMateus.Titular.Cpf = "3659852";



            gustavo.Numero = 1;
            //gustavo.Titular = "Gustavo";
            gustavo.Saldo = 20365;
            gustavo.Titular.Idade = 12;
            gustavo.Sacar(200);

            Console.WriteLine(victor.Saldo);
            Console.WriteLine(contaMateus.Titular.Nome);
        }

    }
}
