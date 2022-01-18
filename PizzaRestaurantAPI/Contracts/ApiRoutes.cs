namespace PizzaRestaurantAPI.Contracts
{
    public static class ApiRoutes
    {
        public const string Base = "api/Pizza/";
        public static class Pizza {
            public const string AddPizza = Base;
            public const string GetAllPizza = Base + "All";
        }
    }
}
