using AbstractFactory.MusicalInstruments.Abstract_Classes.Classifications;

namespace AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.Material_Extensions {
    class Wood : Material {
        public override string ToString() {
            return "Wood from Maple and Spruce trees";
        }
    }
}
