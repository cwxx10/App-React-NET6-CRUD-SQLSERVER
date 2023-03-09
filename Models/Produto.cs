using System;
using System.Collections.Generic;

namespace App_React_NET6_CRUD.Models;

public partial class Produto
{
    public int IdProduto { get; set; }

    public string? Codigo { get; set; }

    public string? Marca { get; set; }

    public string? Descricao { get; set; }

    public int? IdCategoria { get; set; }

    public int? Estoque { get; set; }

    public decimal? Preco { get; set; }

    public bool? IsAtivo { get; set; }

    public DateTime? FecharRegistro { get; set; }

    public virtual ICollection<DetalheVendum> DetalheVenda { get; } = new List<DetalheVendum>();

    public virtual Categorium? IdCategoriaNavigation { get; set; }
}
