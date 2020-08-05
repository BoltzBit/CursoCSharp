using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class CarroOpcional
    {
        double desconto = 0.1;
        string nome;

        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //Propriedades autoimplementada
        public double Preco { get; set; }

        //Somente Leitura
        public double PrecoComDesconto
        {
            //lambda
            get => Preco - (Preco * desconto);
        }

        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Som", 654.52);
            var op2 = new CarroOpcional();

            op2.Nome = "Somzão";
            op2.Preco = 3562.00;

            Console.WriteLine(op1.PrecoComDesconto);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
