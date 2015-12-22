namespace DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions {
    public abstract class CondimentDecorator : Beverage {
        public abstract override string Description { get; }  // Extensions must reimplement GetDescription()
    }
}
