namespace DiegoGasparShop.API.Entities;

public class CarrinhoItem: EntitieBase
{
    public int CarrinhoId { get; set; }
    public int ProdutoId { get; set; }
    public int Quantidade { get; set; }


    public Carrinho? Carrinho{ get; set; }
    public Produto? Produto { get; set; }
}
