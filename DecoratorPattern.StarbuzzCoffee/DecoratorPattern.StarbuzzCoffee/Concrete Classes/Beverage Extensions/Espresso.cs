using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class Espresso : Beverage {
        public Espresso(string size) {
            Size = size;
            Description = Size + " Espresso";
        }

        public override double Cost() {
            switch (Size) {
                case Tall: return 1.69;
                case Grande: return 1.99;
                case Venti: return 2.29;
                default: return -1;
            }
        }
    }
}
