using AdapterPattern.Guitars.Concrete_Classes;
using System;

namespace AdapterPattern.Guitars.Driver_Classes {
    class GuitarDriver {
        static void Main(string[] args) {
            ElectricToAcousticGuitarAdapter adapter = new ElectricToAcousticGuitarAdapter(new AcousticGuitar());
            adapter.TuneInstrument();
            adapter.PickString();
            try {
                adapter.ChangeVolume(6);
            } catch (NotSupportedException) {
                Console.WriteLine("Volume changes aren't supported");
            }

            Console.ReadLine();
        }
    }
}
