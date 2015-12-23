using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Enum_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class Decaf : Beverage {
        public Decaf(BeverageSize size) {
            Size = size;
            Description = Size + " Decaf";
        }

        public override double Cost() {
            switch (Size) {
                case BeverageSize.Tall: return .85;
                case BeverageSize.Grande: return 1.05;
                case BeverageSize.Venti: return 1.25;
                default: return -1;
            }
        }
    }
}
