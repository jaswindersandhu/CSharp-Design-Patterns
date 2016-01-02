using AdapterPattern.Guitars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
