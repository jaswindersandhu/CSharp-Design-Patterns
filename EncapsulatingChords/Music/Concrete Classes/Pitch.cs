using EncapsulatingChords.Helpers;
using System;

namespace EncapsulatingChords.Concrete_Classes
{
    public class Pitch
    {
        private PitchClass _pitchClass;
        private int _octave;
        private double _frequency;

        public PitchClass PitchClass { get { return _pitchClass; } }
        public int Octave { get { return _octave; } }
        public double Frequency { get { return _frequency; } }

        private Pitch(PitchClass pitchClass, int octave)
        {
            _pitchClass = pitchClass;
            _octave = octave;
            _frequency = FrequencyHelper.GetFrequency(pitchClass, octave);
        }

        public static Pitch CreatePitch(string pitch)
        {
            // Since '#' can't be used in enums; I used 's' instead.
            pitch = pitch.Replace('#', 's');

            char octave;
            // Default to octave 4 in case none was provided
            int octaveNumber = 4;

            if (Char.IsDigit(octave = pitch[pitch.Length - 1]))
            {
                // Subtract 48 because '0' == 48.
                octaveNumber = (int)octave - 48;
                pitch = pitch.Substring(0, pitch.Length - 1);
            }

            PitchClass pitchClass = PitchClass.CreatePitchClass(pitch);

            return new Pitch(pitchClass, octaveNumber);
        }
    }
}
