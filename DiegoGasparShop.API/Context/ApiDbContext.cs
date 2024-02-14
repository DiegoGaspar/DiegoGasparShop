using DiegoGasparShop.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DiegoGasparShop.API.Context;

public class ApiDbContext: DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext>opstions): base(opstions)
    {            
    }

    #region Mapeamento de Entidades
    public DbSet<Carrinho>? Carrinhos { get; set; }
    public DbSet<CarrinhoItem>? CarrinhoItens { get; set; }
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Usuario>? Usuarios { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>().HasData( new Categoria 
        { 
            Id = 1,
            Nome= "Beleza",
            IconCSS = "fas fa-spa"
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 1,
            Nome = "Glossier - Beleza Kit",
            Descricao = "Kit fornecido pela Natura",
            Preco = 100,
            Quantidade = 100,
            CategoriaId = 1,
        });
        modelBuilder.Entity<Usuario>().HasData(new Usuario
        {
            Id = 1,
            NomeUsuario = "Admim Teste"
        });
    }
}

