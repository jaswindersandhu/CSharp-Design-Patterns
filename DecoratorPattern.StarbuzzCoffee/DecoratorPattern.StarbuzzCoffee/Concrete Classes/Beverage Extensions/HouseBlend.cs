using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Interfaces;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class HouseBlend : Beverage {
        public HouseBlend(BeverageSize size) {
            Size = size;
            Description = Size + " House Blend Coffee";
        }

        public override double Cost() {
            return .89 + Size.Cost();
        }
    }
}
