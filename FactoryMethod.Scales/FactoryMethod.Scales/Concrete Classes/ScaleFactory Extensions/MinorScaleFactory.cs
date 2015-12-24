using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Concrete_Classes.MinorScale_Extensions;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.ScaleFactory_Extensions {
    class MinorScaleFactory : ScaleFactory {
        public override Scale CreateScale(PitchClass key) {
            switch (key) {
                case PitchClass.A: return new AMinorScale(key);
                case PitchClass.E: return new EMinorScale(key);
                default: return null;
            }
        }
    }
}
