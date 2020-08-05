using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class MetodosEstaticos
    {
        class CalculadoraEstatica
        {
            //não conseguimos acessar o metodo estático apartir da instancia do objeto
            //somente acessamos diretamente pela classe
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }

            //metodos não estaticos podemos acessar pela instancia da classe
            public int Somar(int a, int b)
            {
                return a + b;
            }
        }
        //quando é estático não precisa instanciar, pode acessar diretamente
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(5, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            var somar = new CalculadoraEstatica();

            Console.WriteLine("Somar: {0}", somar.Somar(6,5));

        }
    }
}
