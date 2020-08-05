using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        //construtor da classe Carro
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        //outra forma de criar um construtor padrao
        public Carro() { }
    }

    class Construtores
    {
        public static void Executar()
        {
            //Construtor padrao, instanciando um objeto carro
            var carro1 = new Carro();
            carro1.Modelo = "AT-340";
            carro1.Fabricante = "Mercedez";
            carro1.Ano = 2020;

            //chamando o construtor criado
            var carro2 = new Carro("Uno","Fiat",2020);

            //outra forma de instanciar o objeto
            var carro3 = new Carro()
            {
                Modelo = "onix",
                Fabricante = "Chev",
                Ano = 2020,
            };

            Console.WriteLine("Modelo: {0}; Fabricante: {1}; Ano: {2};",carro1.Modelo,carro1.Fabricante,carro1.Ano);
            Console.WriteLine("Modelo: {0}; Fabricante: {1}; Ano: {2};",carro2.Modelo,carro2.Fabricante,carro2.Ano);
            Console.WriteLine("Modelo: {0}; Fabricante: {1}; Ano: {2};",carro3.Modelo,carro3.Fabricante,carro3.Ano);
        }
    }
}
