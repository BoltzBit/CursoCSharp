using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            //tamanho 5, estrutura homogenea
            string[] alunos = new string[5];

            alunos[0] = "Mateus";
            alunos[1] = "Gustavo";
            alunos[2] = "Jonas";
            alunos[3] = "Jhone";


            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2};

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            Console.WriteLine("Media: " + somatorio / notas.Length);

            char[] letras = { 'a', 'b', 'c' };

            string palavra = new string(letras);

            Console.WriteLine(palavra);
        }
    }
}
