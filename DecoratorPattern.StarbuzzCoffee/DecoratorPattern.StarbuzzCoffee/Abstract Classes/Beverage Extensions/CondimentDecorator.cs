﻿namespace DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions {
    public abstract class CondimentDecorator : Beverage {
        public Beverage beverage { get; set; }
        public abstract override string Description { get; }  // Extensions must reimplement Description property
        public override string Size { get { return beverage.Size; } }
    }
}
