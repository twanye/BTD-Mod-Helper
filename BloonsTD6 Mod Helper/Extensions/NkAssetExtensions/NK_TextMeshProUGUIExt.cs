﻿using Il2CppAssets.Scripts.Unity;
namespace BTD_Mod_Helper.Extensions;

/// <summary>
/// Extensions for NK_TextMeshProUGuis
/// </summary>
public static class NK_TextMeshProUGUIExt
{
    /// <summary>
    /// Gets the localized text for the component
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string GetText(this NK_TextMeshProUGUI text) =>
        Game.instance.GetLocalizationManager().textTable[text.localizeKey];

    /// <summary>
    /// Changes the text in the localization manager for this component
    /// </summary>
    public static void SetText(this NK_TextMeshProUGUI text, string localizeKey, string value)
    {
        var localMgr = Game.instance.GetLocalizationManager();
        if (!localMgr.ContainsKey(localizeKey))
            localMgr.textTable.Add(localizeKey, value);


        text.localizeKey = localizeKey;
        //text.LocalizeTextAsync();    // broken in update 27.0. Not sure what to do to fix it
    }

    /// <summary>
    /// Enables auto sizing for this <see cref="NK_TextMeshProUGUI"/> component
    /// </summary>
    public static void EnableAutoSizing(this NK_TextMeshProUGUI text)
    {
        text.enableAutoSizing = true;
    }

    /// <summary>
    /// Enables or disables auto sizing for this <see cref="NK_TextMeshProUGUI"/> component
    /// </summary>
    public static void EnableAutoSizing(this NK_TextMeshProUGUI text, bool enabled)
    {
        text.enableAutoSizing = enabled;
    }
    /// <summary>
    /// Enables auto sizing for this <see cref="NK_TextMeshProUGUI"/> component
    /// </summary>
    public static void EnableAutoSizing(this NK_TextMeshProUGUI text, float fontSizeMax)
    {
        text.enableAutoSizing = true;
        text.fontSizeMax = fontSizeMax;
    }
    /// <summary>
    /// Enables auto sizing for this <see cref="NK_TextMeshProUGUI"/> component
    /// </summary>
    public static void EnableAutoSizing(this NK_TextMeshProUGUI text, float fontSizeMax, float fontSizeMin)
    {
        text.enableAutoSizing = true;
        text.fontSizeMax = fontSizeMax;
        text.fontSizeMin = fontSizeMin;
    }
}