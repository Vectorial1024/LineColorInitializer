using HarmonyLib;
using JetBrains.Annotations;

namespace LineColorInitializer
{
    [UsedImplicitly]
    [HarmonyPatch(typeof(TransportManager))]
    [HarmonyPatch(nameof(TransportManager.CreateLine), MethodType.Normal)]
    public class PatchTransportManagerCreateLine
    {
        [UsedImplicitly]
        [HarmonyPostfix]
        public static void InitializeLineColor(TransportManager __instance, bool __result, ushort lineID)
        {
            if (!__result)
            {
                // did not create line successfully; don't do it
                return;
            }

            // Created new line
            // Note that this triggers when the line tool first places a stop, which is still acceptable.
            var randomColor = ColorListing.GetRandomColor();
            __instance.m_lines.m_buffer[lineID].m_color = randomColor;
            __instance.m_lines.m_buffer[lineID].m_flags |= TransportLine.Flags.CustomColor;
        }
    }
}
