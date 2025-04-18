//-:cnd:noEmit
#if USEMELONLOADER
using MelonLoader;
#elif USEBEPINEX
using BepInEx;
using BepInEx.Unity.Mono;

using HarmonyLib;
#endif
//+:cnd:noEmit

using MyMod.Logging;

//-:cnd:noEmit
#if USEBEPINEX
//+:cnd:noEmit
namespace MyMod;
#endif

//-:cnd:noEmit
#if USEMELONLOADER
//+:cnd:noEmit
[assembly: MelonInfo(typeof(MyMod.Core), "MyMod", "1.0.0", "CompanyName")]
[assembly: MelonGame("TVGS", "Schedule I")]
namespace MyMod;

//-:cnd:noEmit
#elif USEBEPINEX
[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
#endif
#if USEMELONLOADER
public class Core : MelonMod
#elif USEBEPINEX
public class Core : BaseUnityPlugin
#endif
{
#if USEMELONLOADER
    public override void OnInitializeMelon()
#elif USEBEPINEX
    private void Awake()
#endif
    {
#if USEBEPINEX
        Log.Logger = Logger;
#endif
//+:cnd:noEmit

        Log.LogInfo("Initializing MyMod...");

//-:cnd:noEmit
#if USEBEPINEX
        new Harmony($"com.CompanyName.{MyPluginInfo.PLUGIN_NAME}")
            .PatchAll();
#endif
    }
}
//+:cnd:noEmit