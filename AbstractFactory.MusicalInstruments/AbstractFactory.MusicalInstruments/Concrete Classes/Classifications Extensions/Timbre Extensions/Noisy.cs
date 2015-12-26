using AbstractFactory.MusicalInstruments.Abstract_Classes.Classifications;

namespace AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.Timbre_Extensions {
    class Noisy : Timbre {
        public override string ToString() {
            return "Noisy";
        }
    }
}
