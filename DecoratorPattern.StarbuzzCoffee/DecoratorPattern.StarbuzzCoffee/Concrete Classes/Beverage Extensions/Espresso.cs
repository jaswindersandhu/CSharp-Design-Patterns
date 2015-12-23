using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Utility_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class Espresso : Beverage {
        public Espresso(string size) {
            Size = size;
            Description = Size + " Espresso";
        }

        public override double Cost() {
            switch (Size) {
                case BeverageSizes.Tall: return 1.69;
                case BeverageSizes.Grande: return 1.99;
                case BeverageSizes.Venti: return 2.29;
                default: return -1;
            }
        }
    }
}
