using BlazingPizza.Data;
using BlazingPizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Controllers;

[ApiController]
[Route("pizzas")]
public class PizzaController : ControllerBase
{
    private readonly PizzaStoreContext _db;

    public PizzaController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _db.Tb_Pizzas.ToListAsync()).OrderByDescending(s => s.PrecoBase).ToList();
    }
}