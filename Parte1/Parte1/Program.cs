using Parte1.Controllers;

namespace Parte1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Iniciando a aplicação de teste...");

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

        Console.WriteLine("\nTestes Concluídos.");
    }
}