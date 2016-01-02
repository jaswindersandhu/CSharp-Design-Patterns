using AdapterPattern.Guitars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Guitars.Concrete_Classes {
    class ElectricToAcousticGuitarAdapter : ElectricStringInstrument {
        public AcousticGuitar AcousticGuitar { get; set; }

        public ElectricToAcousticGuitarAdapter(AcousticGuitar acouGuitar) {
            AcousticGuitar = acouGuitar;
        }

        public void ChangeVolume(int vol) {
            throw new NotSupportedException();
        }

        public void PickString() {
            AcousticGuitar.PluckString();
        }

        public void TuneInstrument() {
            AcousticGuitar.TuneInstrument();
        }
    }
}
