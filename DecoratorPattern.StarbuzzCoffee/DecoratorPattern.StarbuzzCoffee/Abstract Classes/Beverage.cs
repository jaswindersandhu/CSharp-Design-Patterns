namespace DecoratorPattern.StarbuzzCoffee.Abstract_Classes {
    public abstract class Beverage {
        public virtual string Description { get; set; } = "Unknown Beverage";
        public virtual string Size { get; set; } = "Unknown Size";

        public abstract double Cost();
    }
}
