using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    public class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }

        public void Soma(Count conta)
        {
            ValorTotal += conta.Saldo;
        }
    }

    class ContaPoupanca : Count
    {
        public override void Sacar(double valor)
        {
            base.Sacar(valor + 0.10);
        }

        public static void Executar()
        {
            ContaPoupanca cp = new ContaPoupanca();
            Count cp2 = new Count();

            cp.Depositar(100);
            cp.Sacar(20);

            cp2.Depositar(320);

            TotalizadorDeContas total = new TotalizadorDeContas();
            total.Soma(cp);
            total.Soma(cp2);

            Console.WriteLine(cp.Saldo);
            Console.WriteLine(total.ValorTotal);
        }
    }
}
