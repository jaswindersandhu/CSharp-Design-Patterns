using System;

namespace FacadePattern.ConductingMusic.Concrete_Classes {
    class OrchestraConductor {
        public StringSection StringSection { get; set; }
        public BrassSection BrassSection { get; set; }
        public PercussionSection PercussionSection { get; set; }
        public WoodwindSection WoodwindSection { get; set; }

        public OrchestraConductor() {
            StringSection = new StringSection();
            BrassSection = new BrassSection();
            PercussionSection = new PercussionSection();
            WoodwindSection = new WoodwindSection();
        }

        public OrchestraConductor(StringSection strings, BrassSection brass, 
                PercussionSection percussion, WoodwindSection woodwinds) {
            StringSection = strings;
            BrassSection = brass;
            PercussionSection = percussion;
            WoodwindSection = woodwinds;
        }

        public void PlayFanfare() {
            Console.WriteLine("\nPlaying a fanfare...");
            BrassSection.StartPlaying();
            PercussionSection.StartPlaying();
        }

        public void StopFanfare() {
            Console.WriteLine("\nStopping the fanfare...");
            BrassSection.StopPlaying();
            PercussionSection.StopPlaying();
        }

        public void PlaySoftly() {
            Console.WriteLine("\nPlaying softly...");
            StringSection.StartPlaying();
            WoodwindSection.StartPlaying();
        }

        public void StopPlayingSoftly() {
            Console.WriteLine("\nCeasing the soft music...");
            StringSection.StopPlaying();
            WoodwindSection.StopPlaying();
        }

        public void PlayTutti() {
            Console.WriteLine("\nPlaying tutti...");
            StringSection.StartPlaying();
            WoodwindSection.StartPlaying();
            BrassSection.StartPlaying();
            PercussionSection.StartPlaying();
        }

        public void StopPlayingTutti() {
            Console.WriteLine("\nStopping everything...");
            StringSection.StartPlaying();
            WoodwindSection.StartPlaying();
            StringSection.StopPlaying();
            WoodwindSection.StopPlaying();
        }
    }
}
