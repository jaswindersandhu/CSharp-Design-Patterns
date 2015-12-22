using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class Decaf : Beverage {
        public Decaf() {
            Description = "Dark Roast";
        }

        public override double Cost() {
            return 1.05;
        }
    }
}
