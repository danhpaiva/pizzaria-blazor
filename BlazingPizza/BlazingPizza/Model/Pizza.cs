namespace BlazingPizza.Model;

public class Pizza
{
    public const int DefaultSize = 12;
    public const int MinimumSize = 9;
    public const int MaximumSize = 17;

    public int Id { get; set; }

    public int OrderId { get; set; }

    public PizzaSpecial PizzaSpecial { get; set; }

    public int SpecialId { get; set; }

    public int Tamanho { get; set; }

    public List<PizzaTopping> ListaRecheios { get; set; }

    public decimal GetPrecoBase()
    {
        return Tamanho / (decimal)DefaultSize * PizzaSpecial.PrecoBase;
    }

    public decimal GetPrecoTotal()
    {
        return GetPrecoBase();
    }

    public string GetPrecoTotalFormatado()
    {
        return GetPrecoTotal().ToString("0.00");
    }
}
