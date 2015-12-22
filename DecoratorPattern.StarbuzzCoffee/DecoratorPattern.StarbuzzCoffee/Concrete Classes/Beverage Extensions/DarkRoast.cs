using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class DarkRoast : Beverage {
        public DarkRoast(string size) {
            Size = size;
            Description = Size + " DarkRoast";
        }

        public override double Cost() {
            switch (Size) {
                case Tall: return .79;
                case Grande: return .99;
                case Venti: return 1.19;
                default: return -1;
            }
        }
    }
}
