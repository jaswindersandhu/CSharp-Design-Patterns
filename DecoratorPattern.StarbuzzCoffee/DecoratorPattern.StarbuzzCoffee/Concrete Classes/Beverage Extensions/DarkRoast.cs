using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class DarkRoast : Beverage {
        public DarkRoast() {
            Description = "Dark Roast";
        }

        public override double Cost() {
            return .99;
        }
    }
}
