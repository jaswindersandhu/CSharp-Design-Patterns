using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Abstract_Classes {
    abstract class ScaleFactory {
        public abstract Scale CreateScale(PitchClass key);
    }
}
