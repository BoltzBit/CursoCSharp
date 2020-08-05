using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Ola".ToUpper().Insert(3, "pessoa").Replace("pessoa", "eu");
            string valorImportante = null;

            Console.WriteLine(saudacao);
            
        }
    }
}
