using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Enum_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class HouseBlend : Beverage {
        public HouseBlend(BeverageSize size) {
            Size = size;
            Description = Size + " House Blend Coffee";
        }

        public override double Cost() {
            switch (Size) {
                case BeverageSize.Tall: return .69;
                case BeverageSize.Grande: return .89;
                case BeverageSize.Venti: return 1.09;
                default: return -1;
            }
        }
    }
}
