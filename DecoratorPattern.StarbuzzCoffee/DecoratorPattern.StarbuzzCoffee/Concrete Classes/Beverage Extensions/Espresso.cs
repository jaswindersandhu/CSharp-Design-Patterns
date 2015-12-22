using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class Espresso : Beverage {
        public Espresso() {
            Description = "Espresso";
        }

        public override double Cost() {
            return 1.99;
        }
    }
}
