using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.Scale_Extensions {
    class MinorScale : Scale {
        public MinorScale() {
            KeyMode = Mode.Minor;
        }
    }
}
