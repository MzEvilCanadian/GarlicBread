using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;

namespace GarlicBread.Customs.GarlicBreadProcess
{
    internal class PlatedGarlicBread : CustomItemGroup
    {
        public override string UniqueNameID => "Plated Garlic Bread";
        public override GameObject Prefab => Mod.Tomato.Prefab;          // Unsure abotu this line
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorageFlags.None;

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Max = 1.
                Min = 1,
                Items = new List<Item>
                {
                    mod.PlatedGarlicBread
                }
            }

        };
    }
}