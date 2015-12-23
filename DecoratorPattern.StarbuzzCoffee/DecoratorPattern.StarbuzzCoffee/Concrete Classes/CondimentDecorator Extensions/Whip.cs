using DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Utility_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions {
    class Whip : CondimentDecorator {
        public override string Description { get { return beverage.Description + ", Whip"; } }

        public Whip(Beverage beverage) {
            this.beverage = beverage;
        }

        public override double Cost() {
            switch (beverage.Size) {
                case BeverageSizes.Tall: return .05 + beverage.Cost();
                case BeverageSizes.Grande: return .10 + beverage.Cost();
                case BeverageSizes.Venti: return .15 + beverage.Cost();
                default: return -1;
            }
        }
    }
}
