using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;

namespace GarlicBread.Customs.GarlicBreadProcess
{
    internal class CookedGarlicBread : CustomItem
    {
        public override string UniqueNameID => "CookedGarlicBread";
        public override GameObject Prefab => Mod.Pumpkin.Prefab;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Small;
        public override int MaxOrderSharers => 2;
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 12,
                Process = Mod.Cook,
                Result = Mod.BurntGarlicBread
            }
        };
    }
}