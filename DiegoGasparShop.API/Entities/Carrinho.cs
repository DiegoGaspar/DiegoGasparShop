using System.Collections.ObjectModel;

namespace DiegoGasparShop.API.Entities;

public class Carrinho: EntitieBase
{
    public int UsuarioId { get; set; }

    public Collection<CarrinhoItem> Itens { get; set; } = new Collection<CarrinhoItem>();
}
