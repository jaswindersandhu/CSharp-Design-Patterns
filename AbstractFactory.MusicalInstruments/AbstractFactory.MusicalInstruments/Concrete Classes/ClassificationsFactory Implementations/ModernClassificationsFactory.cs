using AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.Material_Extensions;
using AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.SoundMedium_Extensions;
using AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.Timbre_Extensions;
using AbstractFactory.MusicalInstruments.Abstract_Classes.Classifications;
using AbstractFactory.MusicalInstruments.Interfaces;

namespace AbstractFactory.MusicalInstruments.Concrete_Classes.ClassificationsFactory_Implementations {
    class ModernClassificationsFactory : ClassificationsFactory {
        public Material[] CreateMaterials() {
            return new Material[] { new CarbonFiber(), new Steel() };
        }

        public SoundMedium CreateSoundMedium() {
            return new Electric();
        }

        public Timbre[] CreateTimbres() {
            return new Timbre[] { new Buzzing(), new Noisy() };
        }
    }
}
