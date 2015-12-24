using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Abstract_Classes.Scale_Extensions {
    abstract class MinorScale : Scale {
        public MinorScale() {
            KeyMode = Mode.Minor;
        }
    }
}
