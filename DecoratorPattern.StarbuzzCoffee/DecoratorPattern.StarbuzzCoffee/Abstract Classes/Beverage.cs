using DecoratorPattern.StarbuzzCoffee.Interfaces;

namespace DecoratorPattern.StarbuzzCoffee.Abstract_Classes {
    abstract class Beverage {
        public virtual string Description { get; set; } = "Unknown Beverage";
        public virtual BeverageSize Size { get; set; }

        public abstract double Cost();
        public override string ToString() {
            return Description + " $" + Cost();
        }
    }
}
