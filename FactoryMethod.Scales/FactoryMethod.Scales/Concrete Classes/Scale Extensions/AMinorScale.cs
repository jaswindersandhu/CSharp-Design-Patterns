using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.Scale_Extensions {
    class AMinorScale : Scale {
        public AMinorScale() : base(PitchClass.A, PitchClass.H, PitchClass.C, PitchClass.D,
            PitchClass.E, PitchClass.F, PitchClass.G) { }

        public override string ToString() {
            return "A minor Scale: " + base.ToString();
        }
    }
}
