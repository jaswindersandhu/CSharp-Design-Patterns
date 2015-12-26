using AbstractFactory.MusicalInstruments.Interfaces;
using AbstractFactory.MusicalInstruments.Abstract_Classes.Classifications;
using System.Text;
using System;

namespace AbstractFactory.MusicalInstruments.Abstract_Classes {
    abstract class Instrument {
        public ClassificationsFactory _ClassificationsFactory { get; set; }
        public string _Name { get; set; }
        public Material[] _Materials { get; set; }
        public SoundMedium _SoundMedium { get; set; }
        public Timbre[] _Timbre { get; set; }

        public void Play() {
            StringBuilder sb = new StringBuilder();
            sb.Append("The following instrument sounds ");
            foreach (Timbre t in _Timbre) {
                sb.Append(t + ", "); //trailing comma; good enough
            }

            Console.WriteLine(sb.ToString());
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + _Name + "\n");
            sb.Append("Materials: ");
            foreach (Material m in _Materials) {
                sb.Append(m + ", ");
            }
            sb.Append("\n");

            return sb.ToString();
        }
    }
}
