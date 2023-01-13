﻿using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GarlicBread.Customs.GarlicBreadProcess
{
    public class GarlicBreadDish : CustomDish
    {
        public override string UniqueNameID => "Garlic Bread -- Base";
        public override DishType Type => DishType.Main;
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
                MenuItem = Mod.PlatedGarlicBread   // Hard cast casts and Exception
            }
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Mod.Flour,
            Mod.Cheese
        };
        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Mod.Cook,
            Mod.Chop,
            Mod.Knead
        };
    }
}