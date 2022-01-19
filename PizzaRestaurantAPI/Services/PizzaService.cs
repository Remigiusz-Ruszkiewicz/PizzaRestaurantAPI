using Microsoft.EntityFrameworkCore;
using PizzaRestaurantAPI.Contracts.Requests;
using PizzaRestaurantAPI.Data;
using PizzaRestaurantAPI.Models;

namespace PizzaRestaurantAPI.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly DatabaseContext _db;
        public PizzaService(DatabaseContext db)
        {
            _db = db;
        }

        public void AddPizzaAsync(PizzaRequest pizzaRequest)
        {
            _db?.Pizzas?.Add(new PizzaModel()
            {
                Id = Guid.NewGuid(),
                Name = pizzaRequest.Name,
                Description = pizzaRequest.Description,
                Ingredients = pizzaRequest.Ingredients,
                Price = pizzaRequest.Price,
            });
            _ = _db?.SaveChanges();
        }

        public async Task<ICollection<PizzaModel>> GetAllPizzasAsync()
        {
            return await _db.Pizzas?.ToListAsync();
        }
    }
}
