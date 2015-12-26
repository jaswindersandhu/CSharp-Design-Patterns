using AbstractFactory.MusicalInstruments.Abstract_Classes.Classifications;

namespace AbstractFactory.MusicalInstruments.Concrete_Classes.Classifications_Extensions.Material_Extensions {
    class Catgut : Material {
        public override string ToString() {
            return "Catgut (not literally gut from cats)";
        }
    }
}
