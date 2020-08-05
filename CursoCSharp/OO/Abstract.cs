using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract void Assistente();

        public string Tocar()
        {
            return "Trim Trim";
        }
    }

    public class Samsumg : Celular
    {
        public override void Assistente()
        {
            Console.WriteLine("Olá eu sou a Bixby");
        }
    }

    public class IPhone : Celular
    {
        public override void Assistente()
        {
            Console.WriteLine("Olá eu sou a Siri");
        }
    }

    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>()
            {
                new IPhone(),
                new Samsumg()
            };

            foreach (var celular in celulares)
            {
                celular.Assistente();
            }
        }
    }
}
