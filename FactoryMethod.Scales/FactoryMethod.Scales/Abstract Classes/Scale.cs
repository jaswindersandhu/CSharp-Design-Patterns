using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Abstract_Classes {
    abstract class Scale {
        public PitchClass Key { get; set; }
        public Mode KeyMode { get; set; }
        public PitchClass Tonic { get; set; }
        public PitchClass Supertonic { get; set; }
        public PitchClass Mediant { get; set; }
        public PitchClass Subdominant { get; set; }
        public PitchClass Dominant { get; set; }
        public PitchClass Submediant { get; set; }
        public PitchClass LeadingTone { get; set; }

        public override string ToString() {
            return string.Format("{0} {1} scale: {2}-{3}-{4}-{5}-{6}-{7}-{8}", Key, KeyMode,
                Tonic, Supertonic, Mediant, Subdominant, Dominant, Submediant, LeadingTone);
        }
    }
}
