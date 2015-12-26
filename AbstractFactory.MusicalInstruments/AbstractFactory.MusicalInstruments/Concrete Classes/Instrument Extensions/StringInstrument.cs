using AbstractFactory.MusicalInstruments.Abstract_Classes;
using AbstractFactory.MusicalInstruments.Interfaces;

namespace AbstractFactory.MusicalInstruments.Concrete_Classes.Instrument_Extensions {
    class StringInstrument : Instrument {
        public StringInstrument(ClassificationsFactory factory) {
            _ClassificationsFactory = factory;
            _Materials = factory.CreateMaterials();
            _SoundMedium = factory.CreateSoundMedium();
            _Timbre = factory.CreateTimbres();
        }
    }
}
