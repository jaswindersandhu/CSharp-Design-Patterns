using DecoratorPattern.StarbuzzCoffee.Interfaces;

namespace DecoratorPattern.StarbuzzCoffee.Concrete_Classes.BeverageSize_Implementations {
    class VentiSize : BeverageSize {
        public double Cost() {
            return 1.00;
        }

        public override string ToString() {
            return "Venti";
        }
    }
}
