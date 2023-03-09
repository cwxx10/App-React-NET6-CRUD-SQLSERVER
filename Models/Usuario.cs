using System;
using System.Collections.Generic;

namespace App_React_NET6_CRUD.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int? IdRol { get; set; }

    public string? Senha { get; set; }

    public bool? IsAtivo { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }

    public virtual ICollection<Vendum> Venda { get; } = new List<Vendum>();
}
