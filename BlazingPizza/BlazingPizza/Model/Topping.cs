namespace BlazingPizza.Model;

public class Topping
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public decimal Preco { get; set; }

    public string GetPrecoFormatado() => Preco.ToString("0.00");
}
