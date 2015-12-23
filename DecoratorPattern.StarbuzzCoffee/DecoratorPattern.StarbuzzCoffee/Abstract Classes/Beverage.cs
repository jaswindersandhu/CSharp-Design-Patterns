namespace DecoratorPattern.StarbuzzCoffee.Abstract_Classes {
    public abstract class Beverage {
        public const string Tall = "Tall";
        public const string Grande = "Grande";
        public const string Venti = "Venti";

        public virtual string Size { get; set; } = "Unknown Size";
        public virtual string Description { get; set; } = "Unknown Beverage";

        public abstract double Cost();
    }
}
