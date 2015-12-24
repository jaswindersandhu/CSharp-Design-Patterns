using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.Scale_Extensions {
    class GMajorScale : Scale {
        public GMajorScale() : base(PitchClass.G, PitchClass.A, PitchClass.H, PitchClass.C, 
            PitchClass.D, PitchClass.E, PitchClass.Fis) { }

        public override string ToString() {
            return "G major Scale: " + base.ToString();
        }
    }
}
