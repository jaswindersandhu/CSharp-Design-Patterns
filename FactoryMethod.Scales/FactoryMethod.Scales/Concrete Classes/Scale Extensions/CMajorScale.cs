using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.Scale_Extensions {
    class CMajorScale : Scale {
        public CMajorScale() : base(PitchClass.C, PitchClass.D, PitchClass.E, PitchClass.F, 
                PitchClass.G, PitchClass.A, PitchClass.H) {
            Key = "C major";
        }
    }
}
