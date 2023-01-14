using KitchenData;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GarlicBreadMod.Dishes
{
    public class GarlicBreadDish : ModDish
    {
        public override string UniqueNameID => "Garlic Bread";
        public override DishType Type => DishType.Starter;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;

        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = Mod.PlatedGarlicBread
            }
        };
        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new HashSet<Dish.IngredientUnlock>
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Mod.UncookedGarlicBread,
                MenuItem = Mod.PlatedGarlicBread   
            }
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Mod.Flour,
            Mod.Cheese,
            Mod.Oil
        };
        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Mod.Cook,
            Mod.Chop,
            Mod.Knead
        };
        public override IDictionary<Locale, string> LocalisedRecipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Add grated cheese to a bread slice then cook. Add oil and serve. Serves 2 customers" }
        };

        public override IDictionary<Locale, UnlockInfo> LocalisedInfo => new Dictionary<Locale, UnlockInfo>
        {
            { Locale.English, LocalisationUtils.CreateUnlockInfo("Garlic Bread", "Adds Garlic Bread as a Starter", "Mmmmm Tasty") }
        };
    }
}