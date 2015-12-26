using System;

namespace SingletonPattern.ChocolateFactory {
    class ChocolateBoiler {
        // private static ChocolateBoiler uniqueInstance = new ChocolateBoiler();  // to "eagerly" create the instance (compile-time)
        private static volatile ChocolateBoiler uniqueInstance;
        private static readonly object syncRoot = new Object();
        public bool Empty { get; set; }
        public bool Boiled { get; set; }

        private ChocolateBoiler() {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler Instance() {
            if (uniqueInstance == null) {
                lock (syncRoot) {
                    if (uniqueInstance == null) { // double-checked locking
                        uniqueInstance = new ChocolateBoiler();
                    }
                }
            }

            return uniqueInstance;
        }

        public void Fill() {
            if (Empty) {
                Empty = false;
                Boiled = false;
            }
        }

        public void Drain() {
            if (!Empty && Boiled) {
                Empty = true;
            }
        }

        public void Boil() {
            if (!Empty && !Boiled) {
                Boiled = true;
            }
        }
    }
}
