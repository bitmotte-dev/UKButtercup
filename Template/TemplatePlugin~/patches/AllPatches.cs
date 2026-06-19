using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using UnityEngine;

namespace Template;

//[HarmonyPatch(typeof(???), "FunctionName")]
public class SimpleExample : MonoBehaviour
{
    static void Prefix(Component __instance)
    {
        
    }

    static void Postfix(Component __instance)
    {
        
    }
}

//[HarmonyPatch(typeof(Projectile))]
//[HarmonyPatch("FixedUpdate")]
public static class TranspilerExample
{
	static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
	{
		var codes = new List<CodeInstruction>(instructions);
        int undesiredStartingPoint = 0;

        for (int i = 0; i < codes.Count; i++)
        {
            //find the first call operation as it is almost exactly where i want to remove
            if(codes[i].opcode == OpCodes.Call)
            {
                undesiredStartingPoint = i - 3;
                break;
            }
        }

        Plugin.Logger.LogInfo(codes[undesiredStartingPoint].opcode);

        return codes.AsEnumerable();
	}
}