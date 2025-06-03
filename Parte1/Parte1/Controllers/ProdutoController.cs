using Parte1.Base;
using Parte1.Models;
using Parte1.Services;
using Parte1.Util;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Parte1.Controllers;

public class ProdutoController : BaseController
{
    private readonly ProdutoService _produtoService;

    public ProdutoController() 
    {
        _produtoService = new ProdutoService();
        Console.WriteLine("ProdutoController instanciado.");
    }

    public override List<string> AcoesProduto { get; } = new List<string> { "Pesquisar", "Salvar", "Excluir" };

    public override (string NomeTela, string CodigoModulo) InformacoesProduto { get; } = ("CADASTRO_PRODUTO", "PRD001");

    public void Index()
    {
        Console.WriteLine("\nMétodo Index do ProdutoController foi chamado.");
        Console.WriteLine($"Ações disponíveis para Produto: {string.Join(", ", AcoesProduto)}");
        Console.WriteLine($"Informações da Tela: {InformacoesProduto.NomeTela}, Módulo: {InformacoesProduto.CodigoModulo}");
    }

    public string Inicializar()
    {
        try
        {
            var produtoViewModel = new ProdutoViewModel()
            {
                NomeProduto = "Smart TV LED",
                Preco = 2500.00
            };

            var resposta = new
            {
                Sucesso = true,
                Mensagem = ObterMensagemSucesso("Módulo inicializado com sucesso!"),
                Dados = new
                {
                    Permissoes = new List<string> { "visualizar", "editar", "deletar" },
                    Usuario = UsuarioLogado.Chave,
                    Produto = produtoViewModel
                }
            };

            return JsonSerializer.Serialize(resposta, new JsonSerializerOptions { WriteIndented = true });
        }
        catch (Exception ex)
        {
            var erroResposta = new
            {
                Sucesso = false,
                Mensagem = ObterMensagemErro($"Ocorreu um erro ao inicializar: {ex.Message}")
            };
            return JsonSerializer.Serialize(erroResposta, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}