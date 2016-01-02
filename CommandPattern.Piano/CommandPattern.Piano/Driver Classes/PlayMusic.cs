using CommandPattern.Piano.Concrete_Classes;
using CommandPattern.Piano.Concrete_Classes.Command_Implementations;
using CommandPattern.Piano.Concrete_Classes.Pitch_Classes;
using System;

namespace CommandPattern.Piano.Driver_Classes {
    class PlayMusic {
        static void Main(string[] args) {
            MyToyPiano piano = new MyToyPiano();
            A a = new A();
            B b = new B();
            C c = new C();
            D d = new D();
            E e = new E();
            F f = new F();
            G g = new G();
            PlayA playA = new PlayA(a);
            PlayB playB = new PlayB(b);
            PlayC playC = new PlayC(c);
            PlayD playD = new PlayD(d);
            PlayE playE = new PlayE(e);
            PlayF playF = new PlayF(f);
            PlayG playG = new PlayG(g);
            piano.SetCommand(0, playA);
            piano.SetCommand(1, playB);
            piano.SetCommand(2, playC);
            piano.SetCommand(3, playD);
            piano.SetCommand(4, playE);
            piano.SetCommand(5, playF);
            piano.SetCommand(6, playG);

            piano.PressKey(0);
            piano.PressKey(2);
            piano.PressKey(4);
            Console.WriteLine();
            piano.PressKey(0);
            piano.PressKey(2);
            piano.PressKey(5);
            Console.WriteLine();
            piano.PressKey(6);
            piano.PressKey(2);
            piano.PressKey(4);
            Console.WriteLine();
            piano.PressKey(6);
            piano.PressKey(1);
            piano.PressKey(3);

            Console.ReadLine();
        }
    }
}
