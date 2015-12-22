using System;
using ObserverPattern.MusicalScales.Concrete_Classes.Subject_Implementations;
using ObserverPattern.MusicalScales.Interfaces;

namespace ObserverPattern.MusicalScales.Concrete_Classes.Observer_Implementations {
    class Dominant : Observer {
        private Subject subject;
        private string tonicChord;

        public Dominant(Subject subject) {
            this.subject = subject;
            subject.RegisterObserver(this);
        }

        public void DisplayChord() {
            Console.WriteLine(tonicChord);
        }

        public void Update(Subject subject) {
            if (subject is Scale) {
                Scale scale = (Scale)subject;
                tonicChord = String.Format("Dominant chord: {0}-{1}-{2}",
                    scale.DiatonicScale[4], scale.DiatonicScale[6], scale.DiatonicScale[1]);
                DisplayChord();
            }
        }
    }
}
