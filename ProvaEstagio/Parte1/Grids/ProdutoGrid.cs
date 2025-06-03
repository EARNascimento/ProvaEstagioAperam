using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1.Grids;

public class ProdutoGrid
{
    public string CodigoProduto { get; set; }
    public string DescricaoProduto { get; set; }

    public static List<ProdutoGrid> ListarProdutosExemplo(int grupoFiltro, int subgrupoFiltro)
    {
        Console.WriteLine($"\nSimulando listagem de produtos para Grupo: {grupoFiltro}, Subgrupo: {subgrupoFiltro}");

        var produtos = new List<ProdutoGrid>
            {
                new ProdutoGrid { CodigoProduto = "PRD001", DescricaoProduto = "Smart TV LED" },
                new ProdutoGrid { CodigoProduto = "PRD002", DescricaoProduto = "Copo Térmico 500ml" },
                new ProdutoGrid { CodigoProduto = "PRD003", DescricaoProduto = "Copo Americano 150ml" },
                new ProdutoGrid { CodigoProduto = "PRD004", DescricaoProduto = "Canudo de Alumínio Reutilizável" },
                new ProdutoGrid { CodigoProduto = "PRD005", DescricaoProduto = "Bolsa Térmica" }
            };

        Console.WriteLine($"Total de produtos encontrados: {produtos.Count}");

        return produtos;
    }
}

