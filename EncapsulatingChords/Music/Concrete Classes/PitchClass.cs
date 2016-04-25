using EncapsulatingChords.Enums;
using EncapsulatingChords.Helpers;
using System;

namespace EncapsulatingChords.Concrete_Classes
{
    public class PitchClass
    {
        private PitchClassName _pitchClassName;
        private int _pitchClassNumber;

        public PitchClassName PitchClassName { get { return _pitchClassName; } }
        public int PitchClassNumber { get { return _pitchClassNumber; } }

        public PitchClass(PitchClassName pitchClassName)
        {
            _pitchClassName = pitchClassName;
            _pitchClassNumber = PitchClassNumberFactory.GetPitchClassNumber(pitchClassName);
        }

        public static PitchClass CreatePitchClass(string pitch)
        {
            var pitchClassName = (PitchClassName)Enum.Parse(typeof(PitchClassName), pitch, true);
            return new PitchClass(pitchClassName);
        }
    }
}
