using UnityEngine;

namespace Template;
static class BundleTool
{
    public static AssetBundle Load(string fileName) {
        AssetBundle bundle = AssetBundle.LoadFromMemory(EmbeddedAccess.AccessFile(fileName));
        return bundle;
    }
}