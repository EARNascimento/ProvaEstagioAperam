namespace Parte1.Services;

public class ProdutoService
{
    public ProdutoService()
    {
        Console.WriteLine("ProdutoService instanciado");
    }

    //Teste de Método
    public string ObterDadosDoProduto(int id)
    {
        return $"Dados do Produto com ID: {id}";
    }
}