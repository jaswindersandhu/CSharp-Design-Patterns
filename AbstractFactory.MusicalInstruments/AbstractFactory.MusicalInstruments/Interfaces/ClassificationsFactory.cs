using AbstractFactory.MusicalInstruments.Abstract_Classes.Classifications;

namespace AbstractFactory.MusicalInstruments.Interfaces {
    interface ClassificationsFactory {
        Material[] CreateMaterials();
        Timbre[] CreateTimbres();
        SoundMedium CreateSoundMedium();
    }
}
