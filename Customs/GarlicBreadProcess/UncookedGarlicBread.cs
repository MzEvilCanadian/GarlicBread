using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;

namespace GarlicBread.Customs.GarlicBreadProcess
{
    internal class UncookedGarlicBread : CustomItemGroup
    {
        public override string UniqueNameID => "Garlic Bread";
        public override GameObject Prefab => Mod.Tomato.Prefab;          // Filler line until graphics are made
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.None;

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>()
        {
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Mod.BreadSlice,
                    Mod.CheeseGrated
                }
            }
        };
        public override List<ItemGroup.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 1,
                Process = Mod.Cook,
                Result = Mod.CookedGarlicBread
            }
        };

        /* Below is to add in the custom graphic for the item

        public override void OnRegister(GameDataObject gdo) 
        {
            gdo.name = "Dish - Garlic Bread";

                 MaterialUtils.ApplyMaterial<MeshRenderer>(Prefab, "Spaghetti/Spaghetti.001", new Material[] {
                 MaterialUtils.GetExistingMaterial("Bread - Bun")});
        } */
    }
}