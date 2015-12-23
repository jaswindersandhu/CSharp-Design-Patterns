using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Utility_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class HouseBlend : Beverage {
        public HouseBlend(string size) {
            Size = size;
            Description = Size + " House Blend Coffee";
        }

        public override double Cost() {
            switch (Size) {
                case BeverageSizes.Tall: return .69;
                case BeverageSizes.Grande: return .89;
                case BeverageSizes.Venti: return 1.09;
                default: return -1;
            }
        }
    }
}
