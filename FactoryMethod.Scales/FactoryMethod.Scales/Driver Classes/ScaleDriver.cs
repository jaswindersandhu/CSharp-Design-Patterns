using FactoryMethod.Scales.Abstract_Classes;
using FactoryMethod.Scales.Concrete_Classes.ScaleFactory_Extensions;
using System;

namespace FactoryMethod.Scales.Driver_Classes {
    class ScaleDriver {
        static void Main(string[] args) {
            ScaleFactory factory = new MajorScaleFactory();
            Scale scale = factory.CreateScale("C");
            Console.WriteLine(scale);
            scale = factory.CreateScale("G");
            Console.WriteLine(scale);

            factory = new MinorScaleFactory();
            scale = factory.CreateScale("A");
            Console.WriteLine(scale);
            scale = factory.CreateScale("E");
            Console.WriteLine(scale);

            Console.ReadLine();
        }
    }
}
