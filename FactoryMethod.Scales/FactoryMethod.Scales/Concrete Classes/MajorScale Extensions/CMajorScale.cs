using FactoryMethod.Scales.Concrete_Classes.Scale_Extensions;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.MajorScale_Extensions {
    class CMajorScale : MajorScale {
        public CMajorScale(PitchClass key) {
            Tonic = PitchClass.C;
            Supertonic = PitchClass.D;
            Mediant = PitchClass.E;
            Subdominant = PitchClass.F;
            Dominant = PitchClass.G;
            Submediant = PitchClass.A;
            LeadingTone = PitchClass.H;

            Key = key;
        }
    }
}
