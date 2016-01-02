using FacadePattern.ConductingMusic.Concrete_Classes;
using System;

namespace FacadePattern.ConductingMusic.Driver_Classes {
    class ConductorTestDrive {
        static void Main(string[] args) {
            OrchestraConductor conductor = new OrchestraConductor(new StringSection(), new BrassSection(),
                    new PercussionSection(), new WoodwindSection());

            conductor.PlayFanfare();
            conductor.StopFanfare();
            conductor.PlaySoftly();
            conductor.StopPlayingSoftly();
            conductor.PlayTutti();
            conductor.StopPlayingTutti();

            Console.ReadLine();
        }
    }
}
