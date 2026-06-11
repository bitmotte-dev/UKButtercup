using PluginConfig.API;
using PluginConfig.API.Decorators;
using PluginConfig.API.Fields;
using PluginConfig.API.Functionals;
using UnityEngine;

namespace ModTechnicalName;

public static class Configurator
{
    public static ButtonField joinDC;


    public static PluginConfigurator CreateConfigurator()
    {
        PluginConfigurator config = PluginConfigurator.Create("ModName", MyPluginInfo.PLUGIN_GUID);

        //ConfigSpace discordGap = new(config.rootPanel,15f);
        //ConfigHeader discordInfo = new(config.rootPanel,"Join my discord for sneak peeks,devlogs,and the possibility to test my mods early ! !",20,TMPro.TextAlignmentOptions.Left);
        //joinDC = new(config.rootPanel,"Join my Discord ! ! !","join_dc");
        //
        //joinDC.onClick += OpenDiscord;
//
        //AssetBundle bundle = BundleTool.Load("main.bundle");
        //Texture2D tex = (Texture2D)bundle.LoadAsset("Assets/baller.png");
        //config.icon = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
        //bundle.Unload(false);

        return config;
    }


    static void OpenDiscord()
    {
        System.Diagnostics.Process.Start("http://discord.gg/pVdr9e6hZ8");
    }
}