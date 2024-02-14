using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DiegoGasparShop.API.Entities;

public class Categoria: EntitieBase
{
    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty;
    public string IconCSS { get; set; } = string.Empty;

    public Collection<Produto> Produtos { get; set;} = new Collection<Produto>();
}
