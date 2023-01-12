using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace GarlicBread.Customs.GarlicBreadProcess
{
    public class GarlicBread : CustomDish
    {
        public override string UniqueNameID => "Garlic Bread -- Base";
        public override DishType Type => DishType.Base;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = Mod.CookedGarlicBread
            }
        };
        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new HashSet<Dish.IngredientUnlock>
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Mod.PlatedGarlicBread,
                MenuItem = Mod.PlatedGarlicBread
            }
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Mod.Flour,
            Mod.Cheese,
        };
        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Mod.Cook
        };

        public override List<ItemGroup.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 2,
                Process = Mod.Cook,
                Result = Mod.CookedGarlicBread
            }
        };

        public override void OnRegister(GameDataObject gdo)
        {
            gdo.name = "Dish - Garlic Bread";

           // MaterialUtils.ApplyMaterial<MeshRenderer>(Prefab, "Spaghetti/Spaghetti.001", new Material[] {
           //     MaterialUtils.GetExistingMaterial("Bread - Bun")});
        }
    }
}