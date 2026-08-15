using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine;

namespace LineColorInitializer
{
    [UsedImplicitly]
    [HarmonyPatch(typeof(TransportManager))]
    [HarmonyPatch(nameof(TransportManager.CreateLine), MethodType.Normal)]
    public class PatchTransportManagerCreateLine
    {
        [UsedImplicitly]
        [HarmonyPostfix]
        public static void InitializeLineColor(bool __result, ushort lineID)
        {
            if (!__result)
            {
                // did not create line successfully; don't do it
                return;
            }

            // Created new line; print for now
            Debug.LogError($"Line created: {lineID}");
        }
    }
}
