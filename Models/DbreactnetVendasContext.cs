using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace App_React_NET6_CRUD.Models;

public partial class DbreactnetVendasContext : DbContext
//Scaffold-DbContext "Server=.; DataBase=DBREACTNET_VENDAS;Integrated Security=true;Encrypt=false" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
{
    public DbreactnetVendasContext()
    {
    }

    public DbreactnetVendasContext(DbContextOptions<DbreactnetVendasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<DetalheVendum> DetalheVenda { get; set; }

    public virtual DbSet<NumeroDocumento> NumeroDocumentos { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vendum> Venda { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.; DataBase=DBREACTNET_VENDAS;Integrated Security=true; Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__8A3D240C282782F1");

            entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.FecharRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecharRegistro");
            entity.Property(e => e.IsAtivo).HasColumnName("isAtivo");
        });

        modelBuilder.Entity<DetalheVendum>(entity =>
        {
            entity.HasKey(e => e.IdDetalheVenda).HasName("PK__DetalheV__61EFE30E4004B4AC");

            entity.Property(e => e.IdDetalheVenda).HasColumnName("idDetalheVenda");
            entity.Property(e => e.IdProduto).HasColumnName("idProduto");
            entity.Property(e => e.IdVenda).HasColumnName("idVenda");
            entity.Property(e => e.Preco)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("preco");
            entity.Property(e => e.Qtd).HasColumnName("qtd");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.DetalheVenda)
                .HasForeignKey(d => d.IdProduto)
                .HasConstraintName("FK__DetalheVe__idPro__35BCFE0A");

            entity.HasOne(d => d.IdVendaNavigation).WithMany(p => p.DetalheVenda)
                .HasForeignKey(d => d.IdVenda)
                .HasConstraintName("FK__DetalheVe__idVen__34C8D9D1");
        });

        modelBuilder.Entity<NumeroDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NumeroDo__3213E83F1E6A0C09");

            entity.ToTable("NumeroDocumento");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.FecharRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecharRegistro");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.IdProduto).HasName("PK__Produto__5EEDF7C37F916585");

            entity.ToTable("Produto");

            entity.Property(e => e.IdProduto).HasColumnName("idProduto");
            entity.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Estoque).HasColumnName("estoque");
            entity.Property(e => e.FecharRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecharRegistro");
            entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");
            entity.Property(e => e.IsAtivo).HasColumnName("isAtivo");
            entity.Property(e => e.Marca)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Preco)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("preco");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Produto__idCateg__2D27B809");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Rol__3C872F76F1F9A1F3");

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.FecharRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecharRegistro");
            entity.Property(e => e.IsAtivo).HasColumnName("isAtivo");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__645723A64F21DDFE");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.IsAtivo).HasColumnName("isAtivo");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Phone)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Senha)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("senha");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Usuario__idRol__276EDEB3");
        });

        modelBuilder.Entity<Vendum>(entity =>
        {
            entity.HasKey(e => e.IdVenda).HasName("PK__Venda__077BEC28E80E4396");

            entity.Property(e => e.IdVenda).HasColumnName("idVenda");
            entity.Property(e => e.DocumentoCliente)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("documentoCliente");
            entity.Property(e => e.FecharRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecharRegistro");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.ImpostoTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("impostoTotal");
            entity.Property(e => e.NomeCliente)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nomeCliente");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("numeroDocumento");
            entity.Property(e => e.SubTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subTotal");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoDocumento");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Venda)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Venda__idUsuario__31EC6D26");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
