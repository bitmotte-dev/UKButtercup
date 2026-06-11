using UnityEngine;

[CreateAssetMenu(menuName = "UKButtercup/Mod")]
public class ButtercupMod : ScriptableObject
{
    [Header("Info")]
    public string modName = "Template Mod";
    public string modTechnicalName = "TemplateMod";
    public string shortDescription = "Template mod !!!!!!";
    
    [Header("Version")]
    public string modVersion = "1.0.0";

    [Header("Preset Features")]
    public bool enemies;
    public bool levels;
    public bool weapons;
    public bool sceneChangers;
    public bool pluginConfig;
    public bool settingsAndKeybinds;
}