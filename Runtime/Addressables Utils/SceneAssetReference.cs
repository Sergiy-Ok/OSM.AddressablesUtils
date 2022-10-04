
using System;
using UnityEngine.AddressableAssets;

namespace OSM.Utils.Addressables
{
    [Serializable]
    public class SceneAssetReference : AssetReference
    {
        public SceneAssetReference(string guid) : base(guid) { }

        public override bool ValidateAsset(string path)
        {
            return path.EndsWith(".unity");
        }
    }
}
