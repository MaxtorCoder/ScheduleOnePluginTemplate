//-:cnd:noEmit
#if USEMELONLOADER
using MelonLoader;
#elif USEBEPINEX
using BepInEx.Logging;
#endif
//+:cnd:noEmit

namespace MyMod.Logging;

//-:cnd:noEmit
public static class Log
{
#if USEBEPINEX
    public static ManualLogSource Logger;
#endif

    /// <summary>
    /// Logs a message with Info level.
    /// </summary>
    /// <param name="message"></param>
    public static void LogInfo(string message)
    {
#if USEBEPINEX
        Logger.LogInfo(message);
#elif USEMELONLOADER
        Melon<Core>.Logger.Msg(message);
#endif
    }

    /// <summary>
    /// Logs a message with Warning level.
    /// </summary>
    /// <param name="message"></param>
    public static void LogWarning(string message)
    {
#if USEBEPINEX
        Logger.LogWarning(message);
#elif USEMELONLOADER
        Melon<Core>.Logger.Warning(message);
#endif
    }

    /// <summary>
    /// Logs a message with Error level.
    /// </summary>
    /// <param name="message"></param>
    public static void LogError(string message)
    {
#if USEBEPINEX
        Logger.LogError(message);
#elif USEMELONLOADER
        Melon<Core>.Logger.Error(message);
#endif
    }

    /// <summary>
    /// Logs a message with Fatal level.
    /// </summary>
    /// <param name="message"></param>
    public static void LogFatal(string message)
    {
#if USEBEPINEX
        Logger.LogFatal(message);
#elif USEMELONLOADER
        Melon<Core>.Logger.BigError(message);
#endif
    }
}
//+:cnd:noEmit
