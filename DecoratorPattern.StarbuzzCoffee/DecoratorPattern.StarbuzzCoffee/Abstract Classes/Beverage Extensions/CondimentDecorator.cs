using DecoratorPattern.StarbuzzCoffee.Interfaces;

namespace DecoratorPattern.StarbuzzCoffee.Abstract_Classes.Beverage_Extensions {
    abstract class CondimentDecorator : Beverage {
        public Beverage beverage { get; set; }
        public abstract override string Description { get; }  // Extensions must reimplement Description property
        public override BeverageSize Size { get { return beverage.Size; } }  //NB this calls the member variable's Size property
    }
}
