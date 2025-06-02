using System;
using System.Collections.Generic;

namespace Parte1.Base;

public abstract class BaseController
{
    public virtual List<string> AcoesProduto { get; } = new List<string> { "Pesquisar", "Salvar" };
    public virtual (string NomeTela, string CodigoModulo) InformacoesProduto { get; } = ("CADASTRO_PRODUTO", "PRD001");

    protected BaseController()
    {
        Console.WriteLine("BaseController instanciado");
    }
}