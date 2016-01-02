using AdapterPattern.Guitars.Interfaces;
using System;

namespace AdapterPattern.Guitars.Concrete_Classes {
    class AcousticGuitar : AcousticStringInstrument {
        public void PluckString() {
            Console.WriteLine("Strumming guitar with fingernails");
        }

        public void TuneInstrument() {
            Console.WriteLine("Tuning to EADGBE with a tuning fork");
        }
    }
}
