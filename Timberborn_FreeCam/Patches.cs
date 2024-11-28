using HarmonyLib;
using Timberborn.CameraSystem;
using Timberborn.Common;

namespace Timberborn_FreeCam
{
    [HarmonyPatch]
    public class Patches
    {
        [HarmonyPatch(typeof(CameraComponent), "ZoomLimits", MethodType.Getter)]
        public static bool Prefix(CameraComponent __instance, ref FloatLimits __result)
        {
            AccessTools.FieldRef<CameraComponent, FloatLimits> freeModeZoomLimits = AccessTools.FieldRefAccess<CameraComponent, FloatLimits>("_freeModeZoomLimits");
            __result = freeModeZoomLimits(__instance);
            return false;
        }
    }
}