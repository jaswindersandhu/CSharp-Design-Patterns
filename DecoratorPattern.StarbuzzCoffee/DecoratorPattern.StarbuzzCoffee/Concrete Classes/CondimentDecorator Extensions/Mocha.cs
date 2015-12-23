using DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions {
    class Mocha : CondimentDecorator {
        public override string Description { get { return beverage.Description + ", Mocha"; } }
        public override string Size { get { return beverage.Size; } }

        public Mocha(Beverage beverage) {
            this.beverage = beverage;
        }

        public override double Cost() {
            switch (beverage.Size) {
                case Tall: return .10 + beverage.Cost();
                case Grande: return .20 + beverage.Cost();
                case Venti: return .30 + beverage.Cost();
                default: return -1;
            }
        }
    }
}
