using System;
using ObserverPattern.MusicalScales.Concrete_Classes.Subject_Implementations;
using ObserverPattern.MusicalScales.Interfaces;

namespace ObserverPattern.MusicalScales.Concrete_Classes.Observer_Implementations {
    class Subdominant : Observer {
        private Subject subject;
        private string tonicChord;

        public Subdominant(Subject subject) {
            this.subject = subject;
            subject.RegisterObserver(this);
        }

        public void DisplayChord() {
            Console.WriteLine(tonicChord);
        }

        public void Update(Subject subject) {
            if (subject is Scale) {
                Scale scale = (Scale)subject;
                tonicChord = String.Format("Subdominant chord: {0}-{1}-{2}",
                    scale.DiatonicScale[3], scale.DiatonicScale[5], scale.DiatonicScale[0]);
                DisplayChord();
            }
        }
    }
}
