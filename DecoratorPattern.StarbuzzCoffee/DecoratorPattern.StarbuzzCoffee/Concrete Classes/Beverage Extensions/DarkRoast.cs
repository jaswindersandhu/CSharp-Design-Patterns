using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Utility_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class DarkRoast : Beverage {
        public DarkRoast(string size) {
            Size = size;
            Description = Size + " DarkRoast";
        }

        public override double Cost() {
            switch (Size) {
                case BeverageSizes.Tall: return .79;
                case BeverageSizes.Grande: return .99;
                case BeverageSizes.Venti: return 1.19;
                default: return -1;
            }
        }
    }
}
