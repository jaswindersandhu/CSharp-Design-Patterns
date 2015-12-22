using DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions {
    class SteamedMilk : CondimentDecorator {
        private Beverage beverage;

        public SteamedMilk(Beverage beverage) {
            this.beverage = beverage;
        }

        public override string Description { get { return beverage.Description + ", Steamed Milk"; } }

        public override double Cost() {
            return .10 + beverage.Cost();
        }
    }
}
