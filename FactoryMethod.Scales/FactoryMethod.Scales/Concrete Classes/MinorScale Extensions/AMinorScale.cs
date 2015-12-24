using FactoryMethod.Scales.Abstract_Classes.Scale_Extensions;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.MinorScale_Extensions {
    class AMinorScale : MinorScale {
        public AMinorScale(PitchClass key) {
            Tonic = PitchClass.A;
            Supertonic = PitchClass.H;
            Mediant = PitchClass.C;
            Subdominant = PitchClass.D;
            Dominant = PitchClass.E;
            Submediant = PitchClass.F;
            LeadingTone = PitchClass.G;

            Key = key;
        }
    }
}
