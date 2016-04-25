using EncapsulatingChords.Enums;
using System.Collections.Generic;

namespace EncapsulatingChords.Concrete_Classes
{
    public class Chord
    {
        private IList<Pitch> _pitches;

        public IList<Pitch> Pitches
        {
            get
            {
                if (_pitches == null)
                {
                    _pitches = new List<Pitch>();
                }

                return _pitches;
            }
        }

        public ChordType ChordSize 
        {
            get 
            {
                if (Pitches.Count >= 0 && Pitches.Count < 5)
                {
                    return (ChordType)Pitches.Count;
                }
                else
                {
                    return ChordType.Extended;
                }
            }
        }

        private Chord() { }

        // Example of @param chordName is "C4 E4 G4"
        public static Chord CreateChord(string chordName)
        {
            Chord chord = new Chord();
            string[] pitches = chordName.Split(' ');

            foreach (string pitch in pitches)
            {
                chord.Pitches.Add(Pitch.CreatePitch(pitch));
            }

            return chord;
        }
    }
}
