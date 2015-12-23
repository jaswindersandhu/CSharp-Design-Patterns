using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Interfaces;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class DarkRoast : Beverage {
        public DarkRoast(BeverageSize size) {
            Size = size;
            Description = Size + " Dark Roast";
        }

        public override double Cost() {
            return .99 + Size.Cost();
        }
    }
}
