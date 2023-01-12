using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;

namespace GarlicBread.Customs.GarlicBreadProcess
{
    internal class BurntGarlicBread : CustomItem
    {
        public override string UniqueNameID => "BurntGarlicBread";
        public override GameObject prefab => Mod.BurntBread.Prefab;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorageFlags.None;
    }
}