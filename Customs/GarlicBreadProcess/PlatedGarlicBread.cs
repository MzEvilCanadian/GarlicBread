using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;

namespace GarlicBreadMod.Customs.GarlicBreadProcess
{
    internal class PlatedGarlicBread : CustomItemGroup
    {
        public override string UniqueNameID => "Plated Garlic Bread";
        public override GameObject Prefab => Mod.Apple.Prefab;          // Filler line until graphics are made
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Max = 2,
                Min = 2,
                Items = new List<Item>
                {
                    Mod.CookedGarlicBread,
                    Mod.OilIngredient
                }
            }
        };
        public override List<ItemGroup.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 12,
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