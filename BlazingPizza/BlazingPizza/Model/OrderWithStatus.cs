namespace BlazingPizza.Model;

public class OrderWithStatus
{
    public readonly static TimeSpan TempoPreparo = TimeSpan.FromSeconds(10);
    public readonly static TimeSpan DuracaoEntrega = TimeSpan.FromMinutes(1); // Nao e real, mas para acompanhar/debugar faz mais sentido

    public Order Order { get; set; }

    public string StatusText { get; set; }

    public bool IsDelivered => StatusText == "Entregue";

    public static OrderWithStatus FromOrder(Order order)
    {
        string statusText;
        var dispatchTime = order.CriadoEm.Add(TempoPreparo);

        if (DateTime.Now < dispatchTime)
        {
            statusText = "Preparando";
        }
        else if (DateTime.Now < dispatchTime + DuracaoEntrega)
        {
            statusText = "Saiu para entrega";
        }
        else
        {
            statusText = "Entregue";
        }

        return new OrderWithStatus
        {
            Order = order,
            StatusText = statusText
        };
    }
}
