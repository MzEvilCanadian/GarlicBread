using KitchenData;
using KitchenLib.Customs;
using UnityEngine;

namespace GarlicBread.Customs.GarlicBreadProcess
{
    internal class CookedGarlicBread : CustomItem
    {
        public override string UniqueNameID => "CookedGarlicBread";
        public override GameObject Prefab => Mod.Pumpkin.Prefab;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override void OnRegister(GameDataObject gameDataObject)
        {
            //Material[] materials = { MaterialUtils.GetExistingMaterial("Bread - Inside") };
            // MaterialUtils.ApplyMaterial(Prefab, "pasta.blend", materials);
        }
    }
}