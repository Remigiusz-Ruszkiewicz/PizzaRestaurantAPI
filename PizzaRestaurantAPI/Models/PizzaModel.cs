using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaRestaurantAPI.Models
{
    public class PizzaModel
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [NotMapped]
        public List<string>? Ingredients { get; set; }
        public decimal Price { get; set; }
    }
}
