using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class Decaf : Beverage {
        public Decaf(string size) {
            Size = size;
            Description = Size + " Decaf";
        }

        public override double Cost() {
            switch (Size) {
                case Tall: return .85;
                case Grande: return 1.05;
                case Venti: return 1.25;
                default: return -1;
            }
        }
    }
}
