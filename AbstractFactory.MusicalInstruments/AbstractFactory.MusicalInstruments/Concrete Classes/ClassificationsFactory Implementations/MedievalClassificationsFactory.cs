using AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.Material_Extensions;
using AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.SoundMedium_Extensions;
using AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.Timbre_Extensions;
using AbstractFactory.MusicalInstruments.Abstract_Classes.Classifications;
using AbstractFactory.MusicalInstruments.Interfaces;

namespace AbstractFactory.MusicalInstruments.Concrete_Classes.ClassificationsFactory_Implementations {
    class MedievalClassificationsFactory : ClassificationsFactory {
        public Material[] CreateMaterials() {
            return new Material[] { new Wood(), new Catgut() };
        }

        public SoundMedium CreateSoundMedium() {
            return new Acoustic();
        }

        public Timbre[] CreateTimbres() {
            return new Timbre[] { new Warm(), new Bright(), new Nasal() };
        }
    }
}
