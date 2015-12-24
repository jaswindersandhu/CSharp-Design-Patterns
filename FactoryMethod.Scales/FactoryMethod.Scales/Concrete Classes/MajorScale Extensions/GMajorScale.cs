using FactoryMethod.Scales.Abstract_Classes.Scale_Extensions;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.MajorScale_Extensions {
    class GMajorScale : MajorScale {
        public GMajorScale(PitchClass key) {
            Tonic = PitchClass.G;
            Supertonic = PitchClass.A;
            Mediant = PitchClass.H;
            Subdominant = PitchClass.C;
            Dominant = PitchClass.D;
            Submediant = PitchClass.E;
            LeadingTone = PitchClass.Fis;

            Key = key;
        }
    }
}
