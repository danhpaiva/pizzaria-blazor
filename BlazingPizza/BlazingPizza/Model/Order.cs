namespace BlazingPizza.Model;

public class Order
{
    public int OrderId { get; set; }

    public string UserId { get; set; }

    public DateTime CriadoEm { get; set; }

    public Address EnderecoEntrega { get; set; } = new Address();

    public List<Pizza> ListaPizzas { get; set; } = new List<Pizza>();

    public decimal GetPrecoTotal() => ListaPizzas.Sum(p => p.GetPrecoTotal());

    public string GetPrecoTotalFormatado() => GetPrecoTotal().ToString("0.00");
}
