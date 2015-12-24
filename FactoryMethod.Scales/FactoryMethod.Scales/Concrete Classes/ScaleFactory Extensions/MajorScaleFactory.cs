using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Concrete_Classes.MajorScale_Extensions;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.ScaleFactory_Extensions {
    class MajorScaleFactory : ScaleFactory {
        public override Scale CreateScale(PitchClass key) {
            switch (key) {
                case PitchClass.C: return new CMajorScale(key);
                case PitchClass.G: return new GMajorScale(key);
                default: return null;
            }
        }
    }
}
