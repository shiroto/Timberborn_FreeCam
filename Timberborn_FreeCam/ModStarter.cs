using HarmonyLib;
using Timberborn.ModManagerScene;

namespace Timberborn_FreeCam
{
    public class ModStarter : IModStarter
    {
        public void StartMod(IModEnvironment modEnvironment)
        {
            Harmony harmony = new("com.marcok.freecam");
            Harmony.DEBUG = true;
            harmony.PatchAll();
        }
    }
}