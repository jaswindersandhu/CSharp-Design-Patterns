﻿using DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Enum_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions {
    class Mocha : CondimentDecorator {
        public override string Description { get { return beverage.Description + ", Mocha"; } }

        public Mocha(Beverage beverage) {
            this.beverage = beverage;
        }

        public override double Cost() {
            switch (beverage.Size) {
                case BeverageSize.Tall: return .10 + beverage.Cost();
                case BeverageSize.Grande: return .20 + beverage.Cost();
                case BeverageSize.Venti: return .30 + beverage.Cost();
                default: return -1;
            }
        }
    }
}
