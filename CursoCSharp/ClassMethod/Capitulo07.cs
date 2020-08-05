using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    //podemos trabalhar com bibliotecas externas usando public
    public class Count
    {
        private string Nome;
        //usando auto-implemented property
        public int Numero { get; set; }
        private Client titular;
        //pode ver, mas somente a classe pode alterar
        public double Saldo { get; protected set; }

        public void ColocarNome(string nome)
        {
            this.Nome = nome;
        }

        //usando properties do C#
        //public int Numero 
        //{
        //    get
        //    {
        //        return this.numero;
        //    }
        //    set
        //    {
        //        this.numero = value;
        //    }
        //}

        public virtual void Sacar(double valor)
        {
            this.Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        //public void ConsultarSaldo()
        //{
        //    Console.WriteLine(this.Saldo);
        //}

        //public double ConsultaSaldo()
        //{
        //    return this.Saldo;
        //}
    }

    class Capitulo07
    {
        public static void Executar()
        {
            Conta mateus = new Conta();
            mateus.Depositar(10020);
            mateus.Sacar(20);
            mateus.Numero = 2;

            Console.WriteLine(mateus.Saldo);
            Console.WriteLine(mateus.Numero);
        }
    }
}
