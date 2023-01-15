using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace GarlicBreadMod.Customs.GarlicBreadProcess
{
    internal class BurntGarlicBread : CustomItem
    {
        public override string UniqueNameID => "BurntGarlicBread";
        public override GameObject Prefab => Mod.BurntBread.Prefab;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.OutsideRubbish;
    }
}