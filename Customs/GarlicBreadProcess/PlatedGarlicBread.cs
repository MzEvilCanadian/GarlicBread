using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace GarlicBreadMod.Customs.GarlicBreadProcess
{
    internal class PlatedGarlicBread : CustomItemGroup
    {
        public override string UniqueNameID => "Plated Garlic Bread";
        public override GameObject Prefab => Mod.bundle.LoadAsset<GameObject>("PlatedGarlicBread");          // Filler line until graphics are made
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override Item DirtiesTo => Mod.ServingBoard;
        public override Item DisposesTo => Mod.ServingBoard;
        public override int MaxOrderSharers => 2;
        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Max = 2,
                Min = 2,
                Items = new List<Item>
                {
                    Mod.CookedGarlicBread,
                    Mod.ServingBoard
                }
            }
        };
        //Below is to add in the custom graphic for the item 
        public override void OnRegister(GameDataObject gameDataObject)
        {
            var materials = new Material[]
            {
                MaterialUtils.GetExistingMaterial("Bread - Inside Cooked"),
            };
            MaterialUtils.ApplyMaterial(Prefab, "GameObject", materials);
            materials[0] = MaterialUtils.GetExistingMaterial("Bread - Cooked");
            MaterialUtils.ApplyMaterial(Prefab, "GameObject (1)", materials);
            materials[0] = MaterialUtils.GetExistingMaterial("Plastic - Yellow");
            MaterialUtils.ApplyMaterial(Prefab, "GameObject (2)", materials);
            materials[0] = MaterialUtils.GetExistingMaterial("Wood 1 - Dim");
            MaterialUtils.ApplyMaterial(Prefab, "GameObject (3)", materials);
            materials[0] = MaterialUtils.GetExistingMaterial("Plastic - Dark Green");
            MaterialUtils.ApplyMaterial(Prefab, "GameObject (4)", materials);

            // MaterialUtils.ApplyMaterial([object], [name], [material list]
        }

    }
}