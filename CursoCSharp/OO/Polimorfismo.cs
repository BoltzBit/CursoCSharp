using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso { get; set; }

        public Comida(double peso)
        {
            Peso = peso;
        }

        public Comida() { }
    }

    public class Arroz : Comida
    {
        public Arroz() : base(0.55) { }
    }

    public class Feijao : Comida
    {
        public Feijao(double peso) : base(peso) { }
    }

    public class Carne : Comida { }


    public class Pessoa
    {
        public double MassaCorporal { get; set; }

        public void AumentoDaMassa(Comida comida)
        {
            MassaCorporal += comida.Peso;
        }

    }

    class Polimorfismo
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa();
            Comida salada = new Comida(0.50);
            Feijao feijao = new Feijao(3.50);
            Arroz arroz = new Arroz();
            Carne carne = new Carne();
            carne.Peso = 6.50;

            pessoa.AumentoDaMassa(salada);
            pessoa.AumentoDaMassa(feijao);
            pessoa.AumentoDaMassa(arroz);
            pessoa.AumentoDaMassa(carne);

            Console.WriteLine("Massa corporal após o almoço: {0}",pessoa.MassaCorporal);

        }
    }
}
