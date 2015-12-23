using DecoratorPattern.StarbuzzCoffee.Interfaces;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.BeverageSize_Implementations {
    class GrandeSize : BeverageSize {
        public double Cost() {
            return .60;
        }

        public override string ToString() {
            return "Grande";
        }
    }
}
