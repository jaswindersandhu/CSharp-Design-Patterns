using EncapsulatingChords.Concrete_Classes;
using System;

namespace EncapsulatingChords.Helpers
{
    public static class FrequencyHelper
    {
        public static double GetFrequency(PitchClass pitchClass, int octave)
        {
            int pianoKeyNumber = GetPianoKeyNumber(pitchClass.PitchClassNumber, octave);

            return Math.Pow(2, (pianoKeyNumber - 49) / 12.0) * 440;
        }

        private static int GetPianoKeyNumber(int pitchClassNumber, int octave)
        {
            return octave * 12 + pitchClassNumber - 8;
        }
    }
}
