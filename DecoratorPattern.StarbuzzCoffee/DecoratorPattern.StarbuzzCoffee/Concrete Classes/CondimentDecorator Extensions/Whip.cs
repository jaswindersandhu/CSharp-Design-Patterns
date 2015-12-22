using DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions {
    class Whip : CondimentDecorator {
        private Beverage beverage;

        public Whip(Beverage beverage) {
            this.beverage = beverage;
        }

        public override string Description { get { return beverage.Description + ", Whip"; } }

        public override double Cost() {
            return .10 + beverage.Cost();
        }
    }
}
