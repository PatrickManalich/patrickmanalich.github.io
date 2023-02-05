using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace PortfolioEditor
{
    public static class AssetEditorExtensions
    {
        [MenuItem("Portfolio/Assets/Reserialize Selected %#&r")]
        public static void ForceReserializeSelectedAssets()
        {
            var assetPaths = new List<string>();
            foreach (var obj in Selection.objects)
            {
                var assetPath = AssetDatabase.GetAssetPath(obj);
                assetPaths.Add(assetPath);
            }
            AssetDatabase.ForceReserializeAssets(assetPaths);
            Debug.Log($"Force reserialized {assetPaths.Count} asset(s)");
        }
    }
}
