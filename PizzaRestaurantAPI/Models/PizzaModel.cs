using System.ComponentModel.DataAnnotations;

namespace PizzaRestaurantAPI.Models
{
    public class PizzaModel
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public IList<string>? Ingredients { get; set; }
        public decimal Price { get; set; }
    }
}
