using DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions {
    class Mocha : CondimentDecorator {
        public override string Description { get { return beverage.Description + ", Mocha"; } }

        public Mocha(Beverage beverage) {
            this.beverage = beverage;
        }

        public override double Cost() {
            return .20 + beverage.Cost();
        }
    }
}
