using DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions {
    class Soy : CondimentDecorator {
        private Beverage beverage;
        public override string Description { get { return beverage.Description + ", Soy"; } }

        public Soy(Beverage beverage) {
            this.beverage = beverage;
            Size = beverage.Size;
        }

        public override double Cost() {
            switch (beverage.Size) {
                case Tall: return .10 + beverage.Cost();
                case Grande: return .15 + beverage.Cost();
                case Venti: return .20 + beverage.Cost();
                default: return -1;
            }
        }
    }
}
