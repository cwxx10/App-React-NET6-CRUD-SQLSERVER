using System;
using System.Collections.Generic;

namespace App_React_NET6_CRUD.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string? Descricao { get; set; }

    public bool? IsAtivo { get; set; }

    public DateTime? FecharRegistro { get; set; }

    public virtual ICollection<Produto> Produtos { get; } = new List<Produto>();
}
