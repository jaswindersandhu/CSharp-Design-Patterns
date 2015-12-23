using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Interfaces;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class Decaf : Beverage {
        public Decaf(BeverageSize size) {
            Size = size;
            Description = Size + " Decaf";
        }

        public override double Cost() {
            return 1.05 + Size.Cost();
        }
    }
}
