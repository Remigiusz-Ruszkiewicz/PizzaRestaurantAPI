using Microsoft.AspNetCore.Mvc;
using PizzaRestaurantAPI.Contracts;
using PizzaRestaurantAPI.Data;
using PizzaRestaurantAPI.Models;

namespace PizzaRestaurantAPI.Controllers
{
    [ApiController]
    public class PizzaMenuController : ControllerBase
    {
        private readonly DatabaseContext _db;
        public PizzaMenuController(DatabaseContext db)
        {
            _db = db;
        }
        [HttpPost(ApiRoutes.Pizza.AddPizza)]
        public void Add([FromBody] PizzaModel pizza)
        {
            _db.Pizzas.Add(pizza);
            _db.SaveChanges();
        }
        [HttpGet(ApiRoutes.Pizza.GetAllPizza)]
        public IEnumerable<PizzaModel> Get() => _db.Pizzas.ToArray();
    }
}