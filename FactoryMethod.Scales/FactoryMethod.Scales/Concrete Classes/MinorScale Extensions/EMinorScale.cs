using FactoryMethod.Scales.Abstract_Classes.Scale_Extensions;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.MinorScale_Extensions {
    class EMinorScale : MinorScale {
        public EMinorScale(PitchClass key) {
            Tonic = PitchClass.E;
            Supertonic = PitchClass.Fis;
            Mediant = PitchClass.G;
            Subdominant = PitchClass.A;
            Dominant = PitchClass.H;
            Submediant = PitchClass.C;
            LeadingTone = PitchClass.D;

            Key = key;
        }
    }
}
