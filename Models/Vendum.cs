using System;
using System.Collections.Generic;

namespace App_React_NET6_CRUD.Models;

public partial class Vendum
{
    public int IdVenda { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? TipoDocumento { get; set; }

    public DateTime? FecharRegistro { get; set; }

    public int? IdUsuario { get; set; }

    public string? DocumentoCliente { get; set; }

    public string? NomeCliente { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? ImpostoTotal { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetalheVendum> DetalheVenda { get; } = new List<DetalheVendum>();

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
