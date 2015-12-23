using DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions {
    class SteamedMilk : CondimentDecorator {
        public override string Description { get { return beverage.Description + ", Steamed Milk"; } }
        public override string Size { get { return beverage.Size; } }

        public SteamedMilk(Beverage beverage) {
            this.beverage = beverage;
        }

        public override double Cost() {
            switch (beverage.Size) {
                case Tall: return .05 + beverage.Cost();
                case Grande: return .10 + beverage.Cost();
                case Venti: return .15 + beverage.Cost();
                default: return -1;
            }
        }
    }
}
