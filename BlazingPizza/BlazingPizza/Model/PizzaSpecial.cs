namespace BlazingPizza.Model;

public class PizzaSpecial
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public decimal PrecoBase { get; set; }

    public string Descricao { get; set; }

    public string ImageUrl { get; set; }

    public string GetPrecoBaseFormatado() => PrecoBase.ToString("0.00");
}
