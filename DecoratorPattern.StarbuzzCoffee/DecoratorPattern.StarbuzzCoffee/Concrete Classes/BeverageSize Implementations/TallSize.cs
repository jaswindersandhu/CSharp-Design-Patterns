using DecoratorPattern.StarbuzzCoffee.Interfaces;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.BeverageSize_Implementations {
    class TallSize : BeverageSize {
        public double Cost() {
            return .20;
        }

        public override string ToString() {
            return "Tall";
        }
    }
}