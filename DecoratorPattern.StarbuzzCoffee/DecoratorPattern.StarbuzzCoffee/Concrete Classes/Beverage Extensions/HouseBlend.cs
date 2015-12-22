using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions {
    class HouseBlend : Beverage {
        public HouseBlend(string size) {
            Size = size;
            Description = Size + " House Blend Coffee";
        }

        public override double Cost() {
            switch (Size) {
                case Tall: return .69;
                case Grande: return .89;
                case Venti: return 1.09;
                default: return -1;
            }
        }
    }
}
