namespace DiegoGasparShop.API.Entities;

public abstract class EntitieBase
{
    public int Id { get; set; }
    public bool Ativo { get; set; } = true;
}
