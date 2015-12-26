using System;

namespace AbstractFactory.MusicalInstruments.Abstract_Classes {
    abstract class InstrumentFactory {
        public Instrument OrderInstrument(string type) {
            Instrument instrument = CreateInstrument(type);
            instrument.Play();

            return instrument;
        }

        public abstract Instrument CreateInstrument(string type);
    }
}
