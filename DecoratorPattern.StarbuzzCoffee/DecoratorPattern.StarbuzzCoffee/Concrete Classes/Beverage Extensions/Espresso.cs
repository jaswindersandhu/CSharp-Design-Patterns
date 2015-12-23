using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Enum_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class Espresso : Beverage {
        public Espresso(BeverageSize size) {
            Size = size;
            Description = Size + " Espresso";
        }

        public override double Cost() {
            switch (Size) {
                case BeverageSize.Tall: return 1.69;
                case BeverageSize.Grande: return 1.99;
                case BeverageSize.Venti: return 2.29;
                default: return -1;
            }
        }
    }
}
