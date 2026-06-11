using System.Collections;
using System.Collections.Generic;
using System.IO;
using TriInspector;
using UnityEditor;
using UnityEditor.Scripting.Python;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtercupCreateMod : EditorWindow
{
    private static VisualTreeAsset createModWindow;
    private static bool alreadyAdded; 

    //info
    private TextField modName;
    private TextField modTechnicalName;
    private TextField shortDescription;

    //version
    private UnsignedIntegerField major;
    private UnsignedIntegerField minor;
    private UnsignedIntegerField patch;

    //feature toggles
    private Toggle enemies;
    private Toggle levels;
    private Toggle weapons;
    private Toggle sceneChangers;
    private Toggle pluginConfig;
    private Toggle settingsAndKeybinds;

    private Button createButton;

    [MenuItem("UKButtercup/Create")]
    public static void ShowWindow()
    {
        GetWindow(typeof(ButtercupCreateMod));
        createModWindow = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/UKButtercup/Editor/Mods/Create.uxml");
        alreadyAdded = false;
    }

    private void OnGUI()
    {
        if(alreadyAdded == false)
        {
            rootVisualElement.Add(createModWindow.CloneTree());
            alreadyAdded = true;
            
            createButton = (Button)rootVisualElement.Q("CreateButton");
            createButton.clicked += CreateMod;

            //info
            modName = (TextField)rootVisualElement.Q("Name");
            modTechnicalName = (TextField)rootVisualElement.Q("TechnicalName");
            shortDescription = (TextField)rootVisualElement.Q("ShortDescription");

            //version
            major = (UnsignedIntegerField)rootVisualElement.Q("Major");
            minor = (UnsignedIntegerField)rootVisualElement.Q("Minor");
            patch = (UnsignedIntegerField)rootVisualElement.Q("Patch");

            //feature toggles
            enemies = (Toggle)rootVisualElement.Q("Enemies");
            levels = (Toggle)rootVisualElement.Q("Weapons");
            weapons = (Toggle)rootVisualElement.Q("Levels");
            sceneChangers = (Toggle)rootVisualElement.Q("SceneChangers");
            pluginConfig = (Toggle)rootVisualElement.Q("PluginConfig");
            settingsAndKeybinds = (Toggle)rootVisualElement.Q("SettingsAndKeybinds");
        }
    }

    private void CreateMod()
    {
        ButtercupMod newMod = new ButtercupMod()
        {
            modName = modName.value,
            modTechnicalName = modTechnicalName.value,
            shortDescription = shortDescription.value,

            modVersion = major.value + "." + minor.value + "." + patch.value,

            enemies = enemies.value,
            levels = levels.value,
            weapons = weapons.value,
            sceneChangers = sceneChangers.value,
            pluginConfig = pluginConfig.value,
            settingsAndKeybinds = settingsAndKeybinds.value
        };

        PythonRunner.EnsureInitialized();

        AssetDatabase.CreateAsset(newMod,"Assets/new.asset");

        Debug.Log(modName.value);
        Debug.Log(modTechnicalName.value);
        Debug.Log(shortDescription.value);

        Debug.Log(major.value);
        Debug.Log(minor.value);
        Debug.Log(patch.value);

        Debug.Log(enemies.value);
        Debug.Log(levels.value);
        Debug.Log(weapons.value);
        Debug.Log(sceneChangers.value);
        Debug.Log(pluginConfig.value);
        Debug.Log(settingsAndKeybinds.value);
    }
}
