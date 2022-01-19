using FluentValidation;

namespace PizzaRestaurantAPI.Contracts.Requests
{
    public class PizzaRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public IList<string>? Ingredients { get; set; }
        public decimal Price { get; set; }
    }
    public class PizzaValidator : AbstractValidator<PizzaRequest>
    {
        public PizzaValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description).MinimumLength(10);
            RuleFor(x => x.Price).InclusiveBetween(0, 100);
            RuleFor(x => x.Ingredients).Must(item => item?.Count >= 1).WithMessage("At least one ingredient has to be added");
        }
    }
}
