using Microsoft.AspNetCore.Mvc;
using PizzaRestaurantAPI.Contracts;
using PizzaRestaurantAPI.Contracts.Requests;
using PizzaRestaurantAPI.Data;
using PizzaRestaurantAPI.Models;
using PizzaRestaurantAPI.Services;

namespace PizzaRestaurantAPI.Controllers
{
    [ApiController]
    public class PizzaMenuController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;

        public PizzaMenuController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        [HttpPost(ApiRoutes.Pizza.AddPizza)]
        public void Add([FromBody] PizzaRequest pizza)
        {
            _pizzaService.AddPizzaAsync(pizza);
        }
        [HttpGet(ApiRoutes.Pizza.GetAllPizza)]
        public async Task<IActionResult> GetAsync() {

            var products = await _pizzaService.GetAllPizzasAsync();
            return Ok(products);
        }
    }
}