using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Interfaces;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class Espresso : Beverage {
        public Espresso(BeverageSize size) {
            Size = size;
            Description = Size + " Espresso";
        }

        public override double Cost() {
            return 1.99 + Size.Cost();
        }
    }
}
