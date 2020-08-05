using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassMethod;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Capitulo04 - Fundamentos", Capitulo04.Executar },
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolacao - Fundamentos", Interpolacao.Executar },
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo valores - Fundamentos", LendoValores.Executar },
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar },
                {"Conversao - Fundamentos", Conversao.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribu~ição - fundamentos", OperadoresDeAtribuicao.Executar },
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar },
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura Else - Estruturas de Controle", EstruturaElse.Executar },
                {"Estrutura If Else - Estruturas de Controle", EstruturaElseIf.Executar },
                {"Switch - Estruturas de Controle", Switch.Executar },
                {"While - Estruturas de Controle", While.Executar },
                {"Do While - Estruturas de Controle", DoWhile.Executar },
                {"For - Estruturas de Controle", For.Executar },
                {"Foreach - Estruturas de Controle",ForEach.Executar },
                {"Break - Estruturas de Controle", Break.Executar },
                {"Continue - Estruturas de Controle", Continue.Executar },
                {"Membros - Class&Method", Membros.Executar },
                {"Capitulo05 - Estrutura de repeticao", Capitulo052.Executar },
                {"Capitulo05 - Exercicio 3",Capitulo053.Executar },
                {"Capitulo05 - Exercicio 4",Capitulo054.Executar },
                {"Capitulo05 - Exercicio 5",Capitulo055.Executar },
                {"Capitulo05 - Exercicio 6",Capitulo056.Executar },
                {"Capitulo05 - Exercicio 7",Capitulo057.Executar },
                {"Capitulo05 - Exercicio 8",Capitulo058.Executar },
                {"Construtores - Class&Methods", Construtores.Executar },
                {"Metodos com Retorno - Class&Methods",MetodosComRetorno.Executar },
                {"Metodos estaticos - Class&Methods", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Class&Methods", AtributosEstaticos.Executar },
                {"Desafio - Class&Methods",DesafioAtributo.Executar },
                {"Params - Class&Methods",Params.Executar },
                {"Parametros Nomeados - Class&Methods",ParametrosNomeados.Executar },
                {"Getters e Setters - Class&Methods", GetSet.Executar },
                {"Propriedades - Class&Methods",Props.Executar },
                {"Cliente - Class&Methods",Readonly.Executar },
                {"Enums - Class&Methods", Enums.Executar },
                {"Struct - Enums", Struct.Executar},
                {"StructVsClass - Class&Methods", StructVsClass.Executar },
                {"Valor vs Referencia - Class&Methods",ValorVsReferencia.Executar },
                {"Parametros por referencia - Class&Methods",ParametrosPorReferencia.Executar },
                {"Parametro por valor - Class&Methods",ParametroPadrao.Executar },
                {"Capitulo06 - Class&Methods",Capitulo06.Executar },
                {"Colecoes - Class&Methods", Colecoes.Array.Executar },
                {"Listas - Class&Methods",List.Executar },
                {"Capitulo 07 - ENCAPSULAMENTO E MODIFICADORESDE ACESSO",Capitulo07.Executar },
                {"Capitulo 08 - Construtores", Capitulo08.Executar },
                {"ArrayList  - Class&Methods",ColecaoArrayList.Executar },
                {"Colecao set - Class&Methods", ColecaoSet.Executar },
                {"Colecao queue - Class&Methods", ColecaoQueue.Executar },
                {"Capitulo10 - Class&Methods",ContaPoupanca.Executar },
                {"Heranca - OO",Heranca.Executar },
                {"Construtor This - OO", ConstrutorThis.Executar },
                {"Encapsulamento - oo",OO.Encapsulamento.Executar },
                {"Poliformismo - OO",Polimorfismo.Executar },
                {"Abstrct - OO",Abstract.Executar },
                {"Interface - OO", Interface.Executar },
                {"Sealed - OO",Sealed.Executar },
                {"Lambda - Metodos e Funcoes",ExemploLambda.Executar },
                {"Delegate - Metodos e Funcoes",LambdaDelegate.Executar },
                {"Usando Delegates - Metodos e Funcoes",UsandoDelegates.Executar },
                {"Delegate funcao anonima - Metodos e Funcoes",DelegateFunAnonima.Executar },
                {"Delegate com Parmetros - Metodos e Funcoes" ,DelegateComParametros.Executar},
                {"Metodos de Extensao - Metodos e Funcoes",MetodosDeExtensao.Executar },
                {"Primeira Excecao - Excecoes",PrimeiraExcecao.Executar },
                {"Excecoes personalizadas - Excecos",ExcecoesPersonalizadas.Executar },
                {"Primeiro Arquivo - Api", PrimeiroArquivo.Executar },
                {"Lendo arquivos - Api", LendoArquivos.Executar },
                {"Exemplo FileInfo - APi", ExemploFileInfo.Executar },
                {"Diretorios - API", Diretorios.Executar },
                {"Diretorio Info - API",DiretorioInfo.Executar },
                {"Usando Path - aPI",UsandoPath.Executar },
                {"Date - API",UsandoDate.Executar},
                {"LINQ1 - Topicos Avancados",LINQ1.Executar },
                {"LINQ2 - Topicos Avancados",LINQ2.Executar },
                {"Nullables - Topicos Avancados",Nullables.Executar },
                {"Dinamico - Topicos Avancados",Dinamico.Executar },
                {"Genericos - Todpicos avancados",Genericos.Executar },

            }); ;

            central.SelecionarEExecutar();
        }
    }
}
