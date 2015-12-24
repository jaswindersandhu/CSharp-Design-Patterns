using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.Scale_Extensions {
    class EMinorScale : Scale {
        public EMinorScale() : base(PitchClass.E, PitchClass.Fis, PitchClass.G, PitchClass.A, 
            PitchClass.H, PitchClass.C, PitchClass.D) { }

        public override string ToString() {
            return "E minor Scale: " + base.ToString();
        }
    }
}
