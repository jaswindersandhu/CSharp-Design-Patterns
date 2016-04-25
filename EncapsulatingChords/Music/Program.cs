using EncapsulatingChords.Concrete_Classes;

namespace EncapsulatingChords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var C = Chord.CreateChord("C E G");
            var Bb7 = Chord.CreateChord("Bb4 D5 F5 Ab5");
            var Em9 = Chord.CreateChord("E3 G3 B3 D4 F#4");
        }
    }
}
