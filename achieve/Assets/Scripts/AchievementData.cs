using UnityEngine;
using System.Collections.Generic;

/*
Data Script which stores and allows access to all of the achievements in the game.
As achievements are implemented, they will be added here.
*/
public static class AchievementData
{
private static List<Achievement> ALL_ACHIEVEMENTS = new List<Achievement>();
    /*{
        /*new Achievement() {achievementName="Walk right!",achievementDescription=""},
        new Achievement() {achievementName="Walk Left!",achievementDescription=""},
        new Achievement() {achievementName="Walk Up!",achievementDescription=""},
        new Achievement() {achievementName="Walk Down!",achievementDescription=""},
        new Achievement() {achievementName="Squawk!",achievementDescription=""},
        new Achievement() {achievementName="Morning Voice",achievementDescription=""},
        new Achievement() {achievementName="Upcoming Singer",achievementDescription=""},
        new Achievement() {achievementName="Jump Start",achievementDescription=""},
        new Achievement() {achievementName="Hip Hop",achievementDescription=""},
        new Achievement() {achievementName="\"Spring\" Chicken",achievementDescription=""},
        new Achievement() {achievementName="R.I.P",achievementDescription=""},
        new Achievement() {achievementName="Fatality",achievementDescription=""},
        new Achievement() {achievementName="The meaning of ...life?",achievementDescription=""},
        new Achievement() {achievementName="That was fast."},
        new Achievement() {achievementName="Alive10s",achievementDescription=""},
        new Achievement() {achievementName="Survivin'",achievementDescription=""},
        new Achievement() {achievementName="Dolania Americana",achievementDescription=""},
        new Achievement() {achievementName="Gradius Fan",achievementDescription=""},
        new Achievement() {achievementName="One!",achievementDescription=""},
        new Achievement() {achievementName="Two!",achievementDescription=""},
        new Achievement() {achievementName="Three!",achievementDescription=""},
        new Achievement() {achievementName="Four!",achievementDescription=""},
        new Achievement() {achievementName="Five!",achievementDescription=""},
        new Achievement() {achievementName="Six!",achievementDescription=""},
        new Achievement() {achievementName="Seven!",achievementDescription=""},
        new Achievement() {achievementName="Eight!",achievementDescription=""},
        new Achievement() {achievementName="Nine!",achievementDescription=""},
        new Achievement() {achievementName="Zero.",achievementDescription=""},
        new Achievement() {achievementName="TOKI WO TOMARE",achievementDescription=""},
        new Achievement() {achievementName="Toki Wa Ugokidasu",achievementDescription=""},
        new Achievement() {achievementName="Wilhelm!",achievementDescription=""},
        new Achievement() {achievementName="Silent Nighthawk",achievementDescription=""},
        new Achievement() {achievementName="DecreaseAudio",achievementDescription=""},
        new Achievement() {achievementName="DecreaseAudio",achievementDescription=""},
        new Achievement() {achievementName="MuteAudio",achievementDescription=""},
        new Achievement() {achievementName="IncreaseVolume",achievementDescription=""},
        new Achievement() {achievementName="1Achievement",achievementDescription=""},
        new Achievement() {achievementName="10Achievement",achievementDescription=""},
        new Achievement() {achievementName="50Achievement",achievementDescription=""},
        new Achievement() {achievementName="LeftMouse",achievementDescription=""},
        new Achievement() {achievementName="RightMouse",achievementDescription=""},
        new Achievement() {achievementName="MiddleMouse",achievementDescription=""},
        new Achievement() {achievementName="SecretSpot",achievementDescription=""},
        new Achievement() {achievementName="FlowerRing",achievementDescription=""},
        new Achievement() {achievementName="FeedFlytrap",achievementDescription=""},
        new Achievement() {achievementName="FeedFlytrap2",achievementDescription=""},
        new Achievement() {achievementName="FeedFlytrap3",achievementDescription=""},
        new Achievement() {achievementName="FeedFlytrap4",achievementDescription=""},
        new Achievement() {achievementName="FeedFlytrap5",achievementDescription=""},
        new Achievement() {achievementName="SettingsMenu",achievementDescription=""},
        new Achievement() {achievementName="CreditsMenu",achievementDescription=""},
        new Achievement() {achievementName="ClickDevAngel",achievementDescription=""},
        new Achievement() {achievementName="ClickDevChristian",achievementDescription=""},
        new Achievement() {achievementName="ClickDevDaniel",achievementDescription=""},
        new Achievement() {achievementName="ClickDevNathan",achievementDescription=""},
        new Achievement() {achievementName="ClickDevThai",achievementDescription=""},
        new Achievement() {achievementName="TrampleFlower",achievementDescription=""},
        new Achievement() {achievementName="TrampleFlower5",achievementDescription=""},
        new Achievement() {achievementName="TrampleFlowerAll",achievementDescription=""}
    };*/

    public static Achievement GetAchievement(string nameToFind)
    {
        return ALL_ACHIEVEMENTS.Find(i => i.achievementName == nameToFind);
    }
    public static void init()
    {
        /*for(int i=1;i<ALL_ACHIEVEMENTS.Count;i++){
            ALL_TRIGGERS[i].achievementID=i;
        }*/
    }
}
