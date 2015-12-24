using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Concrete_Classes.ScaleFactory_Extensions;
using FactoryMethod.Scales.Enums;
using System;

namespace FactoryMethod.Scales.Driver_Classes {
    class ScaleDriver {
        static void Main(string[] args) {
            ScaleFactory factory = new MajorScaleFactory();
            Scale scale = factory.CreateScale(PitchClass.C);
            Console.WriteLine(scale);
            scale = factory.CreateScale(PitchClass.G);
            Console.WriteLine(scale);

            factory = new MinorScaleFactory();
            scale = factory.CreateScale(PitchClass.A);
            Console.WriteLine(scale);
            scale = factory.CreateScale(PitchClass.E);
            Console.WriteLine(scale);

            Console.ReadLine();
        }
    }
}
