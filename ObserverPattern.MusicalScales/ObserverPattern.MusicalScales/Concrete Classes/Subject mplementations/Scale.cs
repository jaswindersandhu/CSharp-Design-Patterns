using System;
using System.Collections.Generic;
using ObserverPattern.MusicalScales.Interfaces;

namespace ObserverPattern.MusicalScales.Concrete_Classes.Subject_Implementations {
    class Scale : Subject {
        public IList<Observer> Observers { get; private set; }
        public string[] DiatonicScale { get; private set; }

        public Scale () {
            Observers = new List<Observer>();
        }

        public void PlayAscendingScale() {
            foreach (string s in DiatonicScale) {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }

        public void PlayDescendingScale() {
            for (int i = DiatonicScale.Length - 1; i >= 0; i--) {
                Console.Write(DiatonicScale[i] + " ");
            }
            Console.WriteLine();
        }

        public void RegisterObserver(Observer o) {
            Observers.Add(o);
        }

        public void RemoveObserver(Observer o) {
            Observers.Remove(o);
        }

        public void NotifyObservers() {
            foreach (Observer o in Observers) {
                o.Update(this);
            }
        }

        public void SetDiatonicScale(String[] scale) {
            this.DiatonicScale = scale;
            PlayAscendingScale();
            NotifyObservers();
        }
    }
}
