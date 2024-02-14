using System.ComponentModel.DataAnnotations;

namespace DiegoGasparShop.API.Entities;

public class Usuario :EntitieBase
{
    [MaxLength(100)]
    public string NomeUsuario { get; set; } = string.Empty;
    public Carrinho? Carrinho { get; set; }
}
