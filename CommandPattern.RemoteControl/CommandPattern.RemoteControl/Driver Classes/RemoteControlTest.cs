using CommandPattern.RemoteControl.Concrete_Classes;
using CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations;
using CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes;
using CommandPattern.RemoteControl.Interfaces;
using System;

namespace CommandPattern.RemoteControl.Driver_Classes {
    class RemoteControlTest {
        static void Main(string[] args) {
            int numSlots = 5;
            BetterRemoteControl remote = new BetterRemoteControl(numSlots);

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLght = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("Downstairs");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(livingRoomLight);

            CeilingFanHighCommand ceilingFanOnHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanOnMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanOnLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageClose = new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            Command[] partyOn = { livingRoomLightOn, ceilingFanOnHigh, stereoOnWithCd };
            Command[] partyOff = { livingRoomLightOff, ceilingFanOff, stereoOff };
            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partOffMacro = new MacroCommand(partyOff);

            Command[] testPartyFanOn = { ceilingFanOnHigh, ceilingFanOnMedium, ceilingFanOnLow };
            Command[] testPartyFanOff = { ceilingFanOff };
            MacroCommand testPartyFanOnMacro = new MacroCommand(testPartyFanOn);
            MacroCommand testPartyFanOffMacro = new MacroCommand(testPartyFanOff);

            //remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            //remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            //remote.SetCommand(2, ceilingFanOnHigh, ceilingFanOff);
            //remote.SetCommand(3, garageOpen, garageClose);
            //remote.SetCommand(4, stereoOnWithCd, stereoOff);
            remote.SetCommand(0, ceilingFanOnHigh, ceilingFanOff);
            remote.SetCommand(1, ceilingFanOnMedium, ceilingFanOff);
            remote.SetCommand(2, ceilingFanOnLow, ceilingFanOff);
            remote.SetCommand(3, partyOnMacro, partOffMacro);
            remote.SetCommand(4, testPartyFanOnMacro, testPartyFanOffMacro);

            Console.WriteLine(remote);

            Console.WriteLine("\n Changing fan settings several times");
            remote.OnButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
            Console.WriteLine("\n Undoing fan settings several times");
            remote.UndoButtonWasPushed();
            remote.UndoButtonWasPushed();
            remote.UndoButtonWasPushed();
            remote.UndoButtonWasPushed();
            remote.UndoButtonWasPushed();

            Console.WriteLine("\nTurning on macro");
            remote.OnButtonWasPushed(3);
            //Console.WriteLine("\nTurning off macro");
            //remote.OffButtonWasPushed(3);
            Console.WriteLine("\nUndoing previous macro button push");
            //Though this eventually calls 3 Undo()'s (one for each of the 3 classes in the MacroCommand's Command[]), the stack in
            //remote control class actually only has 1 object in it, the MacroCommand object
            remote.UndoButtonWasPushed();
            //This won't get called because stack size is not > 0
            remote.UndoButtonWasPushed();

            Console.WriteLine("\nTesting out how fan's handle the macro class");
            remote.OnButtonWasPushed(4);
            Console.WriteLine("\nUndoing the fan macro class");
            remote.UndoButtonWasPushed();

            //remote.OnButtonWasPushed(1);
            //remote.UndoButtonWasPushed();
            //remote.OnButtonWasPushed(1);
            //remote.OffButtonWasPushed(1);
            //remote.OnButtonWasPushed(2);
            //remote.OffButtonWasPushed(2);
            //remote.OnButtonWasPushed(3);
            //remote.OffButtonWasPushed(3);
            //remote.OnButtonWasPushed(4);
            //remote.OffButtonWasPushed(4);

            Console.ReadLine();
        }
    }
}
