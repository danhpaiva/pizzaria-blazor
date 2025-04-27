using BlazingPizza.Data;
using BlazingPizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Controllers;

public class PizzaController
{

    [Route("pizzas")]
    [ApiController]
    public class SpecialsController : Controller
    {
        private readonly PizzaStoreContext _db;

        public SpecialsController(PizzaStoreContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<PizzaSpecial>>> GetPizzas()
        {
            return (await _db.Tb_Pizzas.ToListAsync()).OrderByDescending(s => s.PrecoBase).ToList();
        }
    }
}
