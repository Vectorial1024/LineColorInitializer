using System.Reflection;
using HarmonyLib;

namespace LineColorInitializer
{
    internal class PatchController
    {
        public static string HarmonyModID => "com.vectorial1024.cities.lci";

        /*
         * The "singleton" design is pretty straight-forward.
         */

        private static Harmony _harmony;

        public static Harmony GetHarmonyInstance()
        {
            return _harmony ?? (_harmony = new Harmony(HarmonyModID));
        }

        public static void Activate()
        {
            GetHarmonyInstance().PatchAll(Assembly.GetExecutingAssembly());
        }

        public static void Deactivate()
        {
            GetHarmonyInstance().UnpatchAll(HarmonyModID);
        }
    }
}
