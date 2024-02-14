using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiegoGasparShop.API.Entities;

public class Produto: EntitieBase
{
    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty;
    [MaxLength(200)]
    public string Descricao { get; set; } = string.Empty;
    [MaxLength(200)]
    public string ImgUrl { get; set; } = string.Empty;
    [Column(TypeName="decimal(10,2)")]
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }

    public Collection<CarrinhoItem> Itens { get; set; } = new Collection<CarrinhoItem>();

}
