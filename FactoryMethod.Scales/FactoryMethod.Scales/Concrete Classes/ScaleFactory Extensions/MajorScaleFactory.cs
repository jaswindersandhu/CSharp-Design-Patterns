using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Concrete_Classes.Scale_Extensions;

namespace FactoryMethod.Scales.Concrete_Classes.ScaleFactory_Extensions {
    class MajorScaleFactory : ScaleFactory {
        public override Scale CreateScale(string key) {
            switch (key) {
                case "C": return new CMajorScale();
                case "G": return new GMajorScale();
                default: return null;
            }
        }
    }
}
