using PizzaRestaurantAPI.Contracts.Requests;
using PizzaRestaurantAPI.Models;

namespace PizzaRestaurantAPI.Services
{
    public interface IPizzaService
    {
        Task<ICollection<PizzaModel>> GetAllPizzasAsync();
        void AddPizzaAsync(PizzaRequest pizzaRequest);
    }
}
