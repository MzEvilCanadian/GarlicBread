using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;

namespace GarlicBread.Customs.GarlicBreadProcess
{
    internal class CookedGarlicBread : CustomItemGroup
    {
        public override string UniqueNameID => "Cooked Garlic Bread";
        public override GameObject Prefab => Mod.Pumpkin.Prefab;          // Filler line until graphics are made
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.None;

        public override List<ItemGroup.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 3,
                Process = Mod.Cook,
                Result = Mod.BurntGarlicBread
            }
        };
        /* Below is to add in the custom graphic for the item
        public override void OnRegister(GameDataObject gameDataObject) 
        {
             Material[] materials = { MaterialUtils.GetExistingMaterial("Bread - Inside") };
             MaterialUtils.ApplyMaterial(Prefab, "pasta.blend", materials);
        }
        */
    }
}