using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;

namespace GarlicBread.Customs.GarlicBreadProcess
{
    internal class PlatedGarlicBread : CustomItemGroup
    {
        public override string UniqueNameID => "Cooked Garlic Bread";
        public override GameObject Prefab => Mod.Tomato.Prefab;          // Filler line until graphics are made
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorageFlags.None;

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>()
        {
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Items>()
                {
                    Mod.BreadSliced,
                    Mod.CheeseGrated
                }
            }
        };

        public override void OnRegister(GameDataObject gameDataObject) 
        {
            //Material[] materials = { MaterialUtils.GetExistingMaterial("Bread - Inside") };
            // MaterialUtils.ApplyMaterial(Prefab, "pasta.blend", materials);
        }

        public override List<ItemGroup.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 3,
                Process = Mod.Cook,
                Result = Mod.BurntGarlicBread
            }
        };
    }
}