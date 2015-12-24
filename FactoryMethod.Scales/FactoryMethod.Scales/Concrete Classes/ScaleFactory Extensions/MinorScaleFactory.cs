using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Concrete_Classes.Scale_Extensions;

namespace FactoryMethod.Scales.Concrete_Classes.ScaleFactory_Extensions {
    class MinorScaleFactory : ScaleFactory {
        public override Scale CreateScale(string key) {
            switch (key) {
                case "A": return new AMinorScale();
                case "E": return new EMinorScale();
                default: return null;
            }
        }
    }
}
