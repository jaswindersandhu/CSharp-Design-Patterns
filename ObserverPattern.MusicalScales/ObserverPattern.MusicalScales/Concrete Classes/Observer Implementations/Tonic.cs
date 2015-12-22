using System;
using ObserverPattern.MusicalScales.Concrete_Classes.Subject_Implementations;
using ObserverPattern.MusicalScales.Interfaces;

namespace ObserverPattern.MusicalScales.Concrete_Classes.Observer_Implementations {
    class Tonic : Observer {
        private Subject subject;
        private string tonicChord;

        public Tonic(Subject subject) {
            this.subject = subject;
            subject.RegisterObserver(this);
        }

        public void DisplayChord() {
            Console.WriteLine(tonicChord);
        }

        public void Update(Subject subject) {
            if (subject is Scale) {
                Scale scale = (Scale)subject;
                tonicChord = String.Format("Tonic chord: {0}-{1}-{2}", 
                    scale.DiatonicScale[0], scale.DiatonicScale[2], scale.DiatonicScale[4]);
                DisplayChord();
            }
        }
    }
}
