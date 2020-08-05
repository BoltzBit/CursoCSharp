using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Nota { get; set; }

        public Aluno(string nome, int idade, double nota)
        {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }

        public Aluno() { }
    }

    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno("Mateus",25,6.5),
                new Aluno("Gustavo",26,8.5),
                new Aluno("Jonas",46,8.9),
                new Aluno("Jhone",26,7.5),
                new Aluno("Victor",27,9.8)
            };

            Console.WriteLine("===Aprovados====");
            var aprovados = alunos
                .Where(a => a.Nota >= 7)
                .OrderBy(a => a.Nome);

            foreach (var aluno in aprovados)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
            }

            Console.WriteLine("====Chamada=====");

            var chamada = alunos
                .OrderBy(a => a.Nome)
                .Select(a => a.Nome);

            foreach (var aluno in chamada)
            {
                Console.WriteLine($"Aluno: {aluno}");
            }

            Console.WriteLine("====Alunos Aprovados====");
            var alunosAprovados = from aluno in alunos
                                  where aluno.Nota >= 7
                                  orderby aluno.Idade
                                  select aluno.Nome;

            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine($"Aluno: {aluno}");
            }
        }
    }
}
