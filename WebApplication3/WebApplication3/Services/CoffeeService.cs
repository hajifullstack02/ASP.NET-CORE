
using WebApplication3.Interface;
namespace WebApplication3.Services
{
    public class CoffeeService : ISingletonCoffee, IScopedCoffee, ITransientCoffee
    {
        private readonly string _coffeeId;
        public CoffeeService()
        {
            _coffeeId = Guid.NewGuid().ToString();
        }
        public string GetCoffeeId()
        {
            return _coffeeId;
        }
    }

}
