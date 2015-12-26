using AbstractFactory.MusicalInstruments.Abstract_Classes.Classifications;

namespace AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.SoundMedium_Extensions {
    class Acoustic : SoundMedium {
        public override string ToString() {
            return "Acoustic sound from the instrument itself";
        }
    }
}
