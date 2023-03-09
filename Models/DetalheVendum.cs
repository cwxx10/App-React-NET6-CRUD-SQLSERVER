using System;
using System.Collections.Generic;

namespace App_React_NET6_CRUD.Models;

public partial class DetalheVendum
{
    public int IdDetalheVenda { get; set; }

    public int? IdVenda { get; set; }

    public int? IdProduto { get; set; }

    public int? Qtd { get; set; }

    public decimal? Preco { get; set; }

    public decimal? Total { get; set; }

    public virtual Produto? IdProdutoNavigation { get; set; }

    public virtual Vendum? IdVendaNavigation { get; set; }
}
