using DecoratorPattern.StarbuzzCoffee.Enum_Classes;

namespace DecoratorPattern.StarbuzzCoffee.Abstract_Classes {
    public abstract class Beverage {
        public virtual string Description { get; set; } = "Unknown Beverage";
        public virtual BeverageSize Size { get; set; } = BeverageSize.Unknown;

        public abstract double Cost();
    }
}
