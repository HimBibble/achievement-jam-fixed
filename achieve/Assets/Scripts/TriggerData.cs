using UnityEngine;
using System.Collections.Generic;

/*
Data Script which stores and allows access to all of the triggers in the game.
As triggers are implemented, they will be added here.
*/
public static class TriggerData
{
    private static List<Trigger> ALL_TRIGGERS = new List<Trigger>()
    {
        new Trigger() {triggerName="MoveRight"},
        new Trigger() {triggerName="MoveLeft"},
        new Trigger() {triggerName="MoveUp"},
        new Trigger() {triggerName="MoveDown"},
        new Trigger() {triggerName="Squawk"},
        new Trigger() {triggerName="Squawk5"},
        new Trigger() {triggerName="Squawk50"},
        new Trigger() {triggerName="Jump"},
        new Trigger() {triggerName="Jump5"},
        new Trigger() {triggerName="Jump50"},
        new Trigger() {triggerName="Die"},
        new Trigger() {triggerName="Die5"},
        new Trigger() {triggerName="Die42"},
        new Trigger() {triggerName="DieIn5s"},
        new Trigger() {triggerName="Alive10s"},
        new Trigger() {triggerName="Alive30s"},
        new Trigger() {triggerName="Alive300s"},
        new Trigger() {triggerName="KonamiCode"},
        new Trigger() {triggerName="Key1"},
        new Trigger() {triggerName="Key2"},
        new Trigger() {triggerName="Key3"},
        new Trigger() {triggerName="Key4"},
        new Trigger() {triggerName="Key5"},
        new Trigger() {triggerName="Key6"},
        new Trigger() {triggerName="Key7"},
        new Trigger() {triggerName="Key8"},
        new Trigger() {triggerName="Key9"},
        new Trigger() {triggerName="Key0"},
        new Trigger() {triggerName="Pause"},
        new Trigger() {triggerName="Unpause"},
        new Trigger() {triggerName="VoidOut"},
        new Trigger() {triggerName="NoSquawk60"},
        new Trigger() {triggerName="DecreaseAudio"},
        new Trigger() {triggerName="MuteAudio"},
        new Trigger() {triggerName="IncreaseVolume"},
        new Trigger() {triggerName="1Achievement"},
        new Trigger() {triggerName="10Achievement"},
        new Trigger() {triggerName="50Achievement"},
        new Trigger() {triggerName="LeftMouse"},
        new Trigger() {triggerName="RightMouse"},
        new Trigger() {triggerName="MiddleMouse"},
        new Trigger() {triggerName="SecretSpot"},
        new Trigger() {triggerName="FlowerRing"},
        new Trigger() {triggerName="FeedFlytrap"},
        new Trigger() {triggerName="FeedFlytrap2"},
        new Trigger() {triggerName="FeedFlytrap3"},
        new Trigger() {triggerName="FeedFlytrap4"},
        new Trigger() {triggerName="FeedFlytrap5"},
        new Trigger() {triggerName="SettingsMenu"},
        new Trigger() {triggerName="CreditsMenu"},
        new Trigger() {triggerName="ClickDevAngel"},
        new Trigger() {triggerName="ClickDevChristian"},
        new Trigger() {triggerName="ClickDevDaniel"},
        new Trigger() {triggerName="ClickDevNathan"},
        new Trigger() {triggerName="ClickDevThai"},
        new Trigger() {triggerName="TrampleFlower"},
        new Trigger() {triggerName="TrampleFlower5"},
        new Trigger() {triggerName="TrampleFlowerAll"}
    };

    public static Trigger GetTrigger(string nameToFind){
        return ALL_TRIGGERS.Find(i => i.triggerName == nameToFind);
    }
}
