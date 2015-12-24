using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Enums;

namespace FactoryMethod.Scales.Concrete_Classes.Scale_Extensions {
    class MajorScale : Scale {
        public MajorScale() {
            KeyMode = Mode.Major;
        }
    }
}
