using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Abstract_Classes {
    abstract class Scale {
        public string Key { get; set; }
        public PitchClass Tonic { get; set; }
        public PitchClass Supertonic { get; set; }
        public PitchClass Mediant { get; set; }
        public PitchClass Subdominant { get; set; }
        public PitchClass Dominant { get; set; }
        public PitchClass Submediant { get; set; }
        public PitchClass LeadingTone { get; set; }

        public Scale(PitchClass tonic, PitchClass supertonic, PitchClass mediant, PitchClass subdominant,
            PitchClass dominant, PitchClass submediant, PitchClass leadingTone) {
            Tonic = tonic;
            Supertonic = supertonic;
            Mediant = mediant;
            Subdominant = subdominant;
            Dominant = dominant;
            Submediant = submediant;
            LeadingTone = leadingTone;
        }

        public override string ToString() {
            return string.Format(Key + " scale: {0}-{1}-{2}-{3}-{4}-{5}-{6}",
                Tonic, Supertonic, Mediant, Subdominant, Dominant, Submediant, LeadingTone);
        }
    }
}
