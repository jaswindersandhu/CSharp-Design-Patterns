using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class HouseBlend : Beverage {
        public HouseBlend() {
            Description = "House Blend Coffee";
        }

        public override double Cost() {
            return .89;
        }
    }
}
