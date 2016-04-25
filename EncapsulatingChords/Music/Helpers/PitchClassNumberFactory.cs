using EncapsulatingChords.Enums;

namespace EncapsulatingChords.Helpers
{
    public class PitchClassNumberFactory
    {
        // Can't parse a PitchClass enum when they are assigned the same int values, e.g. Bs = 0, C = 0, Dbb = 0,
        // so I get the int values through this method instead
        public static int GetPitchClassNumber(PitchClassName pitchClass)
        {
            switch (pitchClass)
            {
                case PitchClassName.Bs:
                case PitchClassName.C:
                case PitchClassName.Dbb: return 0;
                case PitchClassName.Bx:
                case PitchClassName.Cs:
                case PitchClassName.Db: return 1;
                case PitchClassName.Cx:
                case PitchClassName.D:
                case PitchClassName.Ebb: return 2;
                case PitchClassName.Ds:
                case PitchClassName.Eb:
                case PitchClassName.Fbb: return 3;
                case PitchClassName.Dx:
                case PitchClassName.E:
                case PitchClassName.Fb: return 4;
                case PitchClassName.Es:
                case PitchClassName.F:
                case PitchClassName.Gbb: return 5;
                case PitchClassName.Ex:
                case PitchClassName.Fs:
                case PitchClassName.Gb: return 6;
                case PitchClassName.Fx:
                case PitchClassName.G:
                case PitchClassName.Abb: return 7;
                case PitchClassName.Gs:
                case PitchClassName.Ab: return 8;
                case PitchClassName.Gx:
                case PitchClassName.A:
                case PitchClassName.Bbb: return 9;
                case PitchClassName.As:
                case PitchClassName.Bb:
                case PitchClassName.Cbb: return 10;
                case PitchClassName.Ax:
                case PitchClassName.B:
                case PitchClassName.Cb: return 11;
                default: return 0;
            }
        }
    }
}
