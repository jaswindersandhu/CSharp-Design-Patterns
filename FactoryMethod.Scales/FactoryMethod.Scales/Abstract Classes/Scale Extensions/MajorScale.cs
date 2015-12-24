using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Abstract_Classes.Scale_Extensions {
    abstract class MajorScale : Scale {
        public MajorScale() {
            KeyMode = Mode.Major;
        }
    }
}
