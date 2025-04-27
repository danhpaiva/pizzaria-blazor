using BlazingPizza.Data;
using BlazingPizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Controllers;

[ApiController] // Aplique o atributo ApiController na classe correta
[Route("pizzas")] // Defina a rota base para este controller
public class SpecialsController : ControllerBase // Herde de ControllerBase para recursos de API
{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet] // Este atributo indica que este método responde a requisições HTTP GET
    public async Task<ActionResult<List<PizzaSpecial>>> GetPizzas()
    {
        var pizzas = await _db.Tb_Pizzas.ToListAsync();
        return Ok(pizzas); // Retorna um status 200 OK com o JSON no corpo
    }
}