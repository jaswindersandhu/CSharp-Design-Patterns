using System;
using ObserverPattern.MusicalScales.Concrete_Classes.Subject_Implementations;
using ObserverPattern.MusicalScales.Concrete_Classes.Observer_Implementations;

namespace ObserverPattern.MusicalScales.Driver_Classes {
    class MusicalScaleDriver {
        public static void Main(string[] args) {
            Scale scale = new Scale();
            Tonic tonic = new Tonic(scale);
            Subdominant subD = new Subdominant(scale);
            Dominant dom = new Dominant(scale);
            scale.SetDiatonicScale(new string[] {"C", "D", "E", "F", "G", "A", "B"});

            scale.RemoveObserver(tonic);
            scale.RemoveObserver(subD);
            Submediant subM = new Submediant(scale);
            scale.SetDiatonicScale(new string[] {"Ab", "Bb", "C", "Db", "Eb", "F", "G"});

            Console.ReadLine();
        }
    }
}
