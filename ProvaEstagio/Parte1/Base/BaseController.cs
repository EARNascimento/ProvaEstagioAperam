using System;
using System.Collections.Generic;

namespace Parte1.Base;

public abstract class BaseController
{
    public virtual List<string> AcoesProduto { get; } = new List<string> { "Visualizar", "Editar" };
    public virtual (string NomeTela, string CodigoModulo) InformacoesProduto { get; } = ("TELA_PADRAO", "MOD000");

    protected BaseController()
    {
        Console.WriteLine("BaseController instanciado");
    }

    protected string ObterMensagemSucesso(string mensagem)
    {
        return $"Sucesso: {mensagem}";
    }

    protected string ObterMensagemErro(string mensagem)
    {
        return $"Erro: {mensagem}";
    }
}