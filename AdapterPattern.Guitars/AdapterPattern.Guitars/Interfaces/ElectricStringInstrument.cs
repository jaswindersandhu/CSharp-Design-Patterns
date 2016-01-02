using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Guitars.Interfaces {
    interface ElectricStringInstrument {
        void TuneInstrument();
        void PickString();
        void ChangeVolume(int vol);
    }
}
