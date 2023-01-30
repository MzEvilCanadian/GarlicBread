﻿using GarlicBreadMod.Customs.GarlicBreadProcess;
using GarlicBreadMod.Registry;
using GarlicBreadMod.Dishes;
using KitchenData;
using KitchenLib;
using KitchenLib.References;
using KitchenLib.Utils;
using KitchenMods;
using KitchenLib.Event;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using ItemReference = KitchenLib.References.ItemReferences;

namespace GarlicBreadMod
{
    public class Main : BaseMod
    {
        internal const string MOD_ID = "GarlicBread";
        internal const string MOD_NAME = "Garlic Bread";
        internal const string MOD_VERSION = "1.1.0";
        internal const string MOD_AUTHOR = "MzEvilCanadian";
        public const string MOD_GAMEVERSION = ">=1.1.3";

        public static AssetBundle bundle;

        internal static Item Tomato => GetExistingGDO<Item>(ItemReference.Tomato);
        internal static Item ServingBoard => GetExistingGDO<Item>(ItemReference.ServingBoard);
        internal static Item Flour => GetExistingGDO<Item>(ItemReference.Flour);
        internal static Item Cheese => GetExistingGDO<Item>(ItemReference.Cheese);
        public static Item Garlic => Find<Item>(IngredientLib.References.GetIngredient("garlic"));
        public static Item MincedGarlic => Find<Item>(IngredientLib.References.GetIngredient("minced garlic"));

        internal static Process Cook => GetExistingGDO<Process>(ProcessReferences.Cook);
        internal static Process Chop => GetExistingGDO<Process>(ProcessReferences.Chop);
        internal static Process Knead => GetExistingGDO<Process>(ProcessReferences.Knead);

        internal static Item BreadSlice => GetExistingGDO<Item>(ItemReference.BreadSlice);
        internal static Item CheeseGrated => GetExistingGDO<Item>(ItemReference.CheeseGrated);

        internal static Item BurntGarlicBread => GetModdedGDO<Item, BurntGarlicBread>();
        internal static ItemGroup UncookedGarlicBread => GetModdedGDO<ItemGroup, UncookedGarlicBread>();
        internal static ItemGroup UncookedGarlicBread2 => GetModdedGDO<ItemGroup, UncookedGarlicBread2>();
        internal static ItemGroup PlatedGarlicBread => GetModdedGDO<ItemGroup, PlatedGarlicBread>();
        internal static Item CookedGarlicBread => GetModdedGDO<Item, CookedGarlicBread>();
        internal static Dish GarlicBreadDish => GetModdedGDO<Dish, GarlicBreadDish>();



        internal static bool debug = true;
        public static void LogInfo(string _log) { Debug.Log($"[{MOD_NAME}] " + _log); }
        public static void LogInfo(object _log) { LogInfo(_log.ToString()); }

        public Main() : base(MOD_ID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, $"{MOD_GAMEVERSION}", Assembly.GetExecutingAssembly())
        {
            string bundlePath = Path.Combine(new string[] { Directory.GetParent(Application.dataPath).FullName, "Mods", ModID });

            Debug.Log($"{MOD_NAME} {MOD_VERSION} {MOD_AUTHOR}: Loaded");
            Debug.Log($"Assets Loaded From {bundlePath}");
        } 
        public override void PostActivate(KitchenMods.Mod mod)
        {
            base.PostActivate(mod);
            bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).ToList()[0];

            AddGameDataObject<BurntGarlicBread>();
            AddGameDataObject<CookedGarlicBread>();
            AddGameDataObject<UncookedGarlicBread>();
            AddGameDataObject<UncookedGarlicBread2>();
            AddGameDataObject<PlatedGarlicBread>();
            AddGameDataObject<GarlicBreadDish>();

            Events.BuildGameDataEvent += delegate (object s, BuildGameDataEventArgs args)
            {
                ModRegistry.HandleBuildGameDataEvent(args);
            };
        }
        protected override void OnUpdate() { }
        private static T1 GetModdedGDO<T1, T2>() where T1 : GameDataObject
        {
            return (T1)GDOUtils.GetCustomGameDataObject<T2>().GameDataObject;
        }
        private static T GetExistingGDO<T>(int id) where T : GameDataObject
        {
            return (T)GDOUtils.GetExistingGDO(id);
        }
        internal static T Find<T>(int id) where T : GameDataObject
        {
            return (T)GDOUtils.GetExistingGDO(id) ?? (T)GDOUtils.GetCustomGameDataObject(id)?.GameDataObject;
        }
    }
}