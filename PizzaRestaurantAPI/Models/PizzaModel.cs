using FluentValidation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;

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
    public class PizzaValidator : AbstractValidator<PizzaModel>
    {
        public PizzaValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description).MinimumLength(10);
            RuleFor(x => x.Price).InclusiveBetween(0, 100);
            RuleFor(x => x.Ingredients).Must(item => item.Count >= 1).WithMessage("At least one ingredient has to be added");
        }
    }
}
