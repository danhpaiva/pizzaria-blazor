using BlazingPizza.Model;

namespace BlazingPizza.Services;

public class PedidoEstado
{
    public bool MostrarJanelaConfig { get; private set; }
    public Pizza ConfiguracaoPizza { get; private set; }
    public Order Pedido { get; private set; } = new Order();

    public void MostrarJanelaConfiguracaoPizza(PizzaSpecial special)
    {
        ConfiguracaoPizza = new Pizza()
        {
            PizzaSpecial = special,
            SpecialId = special.Id,
            Tamanho = Pizza.DefaultSize,
            ListaRecheios = new List<PizzaTopping>(),
        };

        MostrarJanelaConfig = true;
    }

    public void CancelarJanelaConfiguracaoPizza()
    {
        ConfiguracaoPizza = null;

        MostrarJanelaConfig = false;
    }

    public void ConfirmarJanelaConfiguracaoPizza()
    {
        Pedido.ListaPizzas.Add(ConfiguracaoPizza);
        ConfiguracaoPizza = null;

        MostrarJanelaConfig = false;
    }

    public void RemoverConfiguracaoPizza(Pizza pizza)
    {
        Pedido.ListaPizzas.Remove(pizza);
    }
}
