using DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions {
    class Whip : CondimentDecorator {
        private Beverage beverage;
        public override string Description { get { return beverage.Description + ", Whip"; } }

        public Whip(Beverage beverage) {
            this.beverage = beverage;
            Size = beverage.Size;
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
