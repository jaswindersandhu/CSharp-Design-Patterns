using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Enum_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class DarkRoast : Beverage {
        public DarkRoast(BeverageSize size) {
            Size = size;
            Description = Size + " Dark Roast";
        }

        public override double Cost() {
            switch (Size) {
                case BeverageSize.Tall: return .79;
                case BeverageSize.Grande: return .99;
                case BeverageSize.Venti: return 1.19;
                default: return -1;
            }
        }
    }
}
