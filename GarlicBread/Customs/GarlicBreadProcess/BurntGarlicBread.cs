using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;

// I feel like something is missing in this file

namespace GarlicBread.Customs.GarlicBreadProcess
{
    internal class BurntGarlicBread : CustomItem
    {
        public override string UniqueNameID => "BurntGarlicBread";
        public override GameObject prefab => Mod.Tomato.Prefab;   // Unsure what this line does
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorageFlags.None;
    }
}