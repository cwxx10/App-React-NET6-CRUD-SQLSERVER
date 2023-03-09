using System;
using System.Collections.Generic;

namespace App_React_NET6_CRUD.Models;

public partial class Rol
{
    public int IdRol { get; set; }

    public string? Descricao { get; set; }

    public bool? IsAtivo { get; set; }

    public DateTime? FecharRegistro { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
