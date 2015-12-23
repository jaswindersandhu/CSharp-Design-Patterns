using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Utility_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class Decaf : Beverage {
        public Decaf(string size) {
            Size = size;
            Description = Size + " Decaf";
        }

        public override double Cost() {
            switch (Size) {
                case BeverageSizes.Tall: return .85;
                case BeverageSizes.Grande: return 1.05;
                case BeverageSizes.Venti: return 1.25;
                default: return -1;
            }
        }
    }
}
