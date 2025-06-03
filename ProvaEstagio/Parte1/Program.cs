using Parte1.Controllers;
using Parte1.Grids;
using System;

namespace Parte1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Iniciando a aplicação de teste...");

        //Testes da Parte 1

        //Instanciando ProdutoController
        Console.WriteLine("Teste ProdutoController");
        ProdutoController produtoController = new ProdutoController();

        //Método Index
        produtoController.Index();

        //Método Inicializar e a resposta do Json
        Console.WriteLine("\n Chamando o método Inicializar");
        string respostaJson = produtoController.Inicializar();
        Console.WriteLine("Resposta JSON do Inicializar:");
        Console.WriteLine(respostaJson);

        //Testes da Parte 2

        List<ProdutoGrid> listaDeProdutos = ProdutoGrid.ListarProdutosExemplo(101, 20);

        Console.WriteLine("Teste ProdutoGrid e ListarProdutos");

        Console.WriteLine("\nProdutos Carregados: ");
        foreach (var produto in listaDeProdutos)
        {
            Console.WriteLine($"Código: {produto.CodigoProduto}, Descrição: {produto.DescricaoProduto}");
        }

        //Conclusão de Testes
        Console.WriteLine("\nTestes Concluídos.");
    }
}