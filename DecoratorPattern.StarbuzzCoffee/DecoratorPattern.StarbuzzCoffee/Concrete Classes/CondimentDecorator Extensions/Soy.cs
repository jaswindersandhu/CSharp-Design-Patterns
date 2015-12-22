using DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions {
    class Soy : CondimentDecorator {
        private Beverage beverage;

        public Soy(Beverage beverage) {
            this.beverage = beverage;
        }

        public override string Description { get { return beverage.Description + ", Soy"; } }

        public override double Cost() {
            return .15 + beverage.Cost();
        }
    }
}
