using AbstractFactory.MusicalInstruments.Abstract_Classes.Classifications;

namespace AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.SoundMedium_Extensions {
    class Electric : SoundMedium {
        public override string ToString() {
            return "Electric sound from an amplifier";
        }
    }
}
