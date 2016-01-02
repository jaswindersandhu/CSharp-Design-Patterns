using AdapterPattern.Guitars.Interfaces;
using System;

namespace AdapterPattern.Guitars.Concrete_Classes {
    class ElectricGuitar : ElectricStringInstrument {
        public int Volume { set; get; }

        public void ChangeVolume(int vol) {
            Volume = vol;
        }

        public void PickString() {
            Console.WriteLine("Strumming guitar with plectrum");
        }

        public void TuneInstrument() {
            Console.WriteLine("Tuning to EADGBE with an electronic tuner");
        }
    }
}
