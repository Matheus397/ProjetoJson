using System;
using System.Collections.Generic;
//Escopo geral

//Desenvolver um console application  que lê um arquivo JSON(fornecido)  mapeia os objetos e imprime na tela

//Requisitos

//1 - Após a leitura dos dados o app deverá dar as seguintes opções ao usuário:

//1.1 - Remover um registro
//1.2 - Salvar alteração em um NOVO arquivo JSON e manter o original INTACTO
namespace PROJETO_TREINO
{
    class Program
    {

        static void Main(string[] args)
        {

            Trabalho trabalho = new Trabalho();
            JsonAltera json = new JsonAltera();

            Guid idArquivo;
            idArquivo = Guid.NewGuid();

            string Path = @"C:\Users\Treinamento 1\Desktop\PROJETO_TREINO\PROJETO_TREINO\Trabalho1.json";

            string novo = $@"C:\Users\Treinamento 1\Desktop\PROJETO_TREINO\PROJETO_TREINO\Trabalho_{idArquivo}.json";

            bool laco = true;

            List<Trabalho> colecao;

            colecao = json.Desserializador(Path);


            while (laco == true)
            {
                
                Console.WriteLine("Bem vindo ao menu!\nDigite: 1 para remover um registro;\nDigite: 2 para sair!");
                Int32.TryParse(Console.ReadLine(), out int op);

                if (op != 1 && op != 2)
                {
                    while (op != 1 && op != 2)
                    {
                        Console.WriteLine("digite 1 ou 2 para retomar o processo!");
                        Int32.TryParse(Console.ReadLine(), out op);

                    }
                }
                else if (op == 1)
                {                  

                        Console.WriteLine("Digite o indice a ser removido\n(Caso o índice inserido seja vazio ou menor do que o tamanho da lista, removeremos o de menor índice ");

                        Int32.TryParse(Console.ReadLine(), out int e);

                        if (colecao.Contains(colecao[e]))
                        {
                            try
                            {

                                var removido = colecao[e];

                                colecao.Remove(removido);

                                Console.Clear();

                                Console.WriteLine("Registro Retirado da base!");

                                Console.WriteLine();

                            }
                            catch (Exception q)
                            {

                                Console.WriteLine(q.Message);

                            }
                            finally
                            {
                                foreach (var qualquer in colecao)
                                {

                                    Console.WriteLine(qualquer.ToString());

                                }
                            }
                        }
                    
                else if (op == 2)
                    {

                        laco = false;
                        Console.WriteLine("Até Mais!!!");

                    }
                }
            }
           
            
            
            json.Serializador(colecao, novo);
        }
    }
}


