#if (useMelonLoader)
using MelonLoader;
#elseif (useBepInEx)
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.Mono;

using HarmonyLib;
#endif

#if (useBepInEx)
namespace MyMod;
#endif

#if (useMelonLoader)
[assembly: MelonInfo(typeof(MyMod.Core), "MyMod", "1.0.0", "CompanyName")]
[assembly: MelonGame("TVGS", "Schedule I")]
namespace MyMod;

#elseif (useBepInEx)
[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
#endif
#if (useMelonLoader)
public class Core : MelonMod
#elseif (useBepInEx)
public class Core : BaseUnityPlugin
#endif
{
    #if (useBepInEx)
    internal new static ManualLogSource Logger;
    #endif

    #if (useMelonLoader)
    public override void OnInitializeMelon()
    {
        LoggerInstance.Msg("Initialized.");
    }
    #elseif (useBepInEx)
    void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_NAME} is loaded!");

        new Harmony($"com.CompanyName.{MyPluginInfo.PLUGIN_NAME}")
            .PatchAll();
    }
    #endif
}