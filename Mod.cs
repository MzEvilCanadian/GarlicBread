using GarlicBreadMod.Customs.GarlicBreadProcess;
using GarlicBreadMod.Registry;
using GarlicBreadMod.Dishes;
using KitchenData;
using KitchenLib;
using KitchenLib.References;
using KitchenLib.Utils;
using System.IO;
using System;
using System.Reflection;
using UnityEngine;
using KitchenMods;
using ItemReference = KitchenLib.References.ItemReferences;
using System.Linq;

namespace GarlicBreadMod
{
    public class Mod : BaseMod
    {
        internal const string MOD_ID = "GarlicBread";
        internal const string MOD_NAME = "Garlic Bread";
        internal const string MOD_VERSION = "0.2.9";
        internal const string MOD_AUTHOR = "MzEvilCanadian";
        internal const string PLATEUP_VERSION = "1.1.2";

        public static AssetBundle bundle;

        internal static Item Tomato => GetExistingGDO<Item>(ItemReference.Tomato);
        internal static Item Apple => GetExistingGDO<Item>(ItemReference.Apple);
        internal static Item Pumpkin => GetExistingGDO<Item>(ItemReference.Pumpkin);
        internal static Item ServingBoard => GetExistingGDO<Item>(ItemReference.ServingBoard);
        internal static Item Flour => GetExistingGDO<Item>(ItemReference.Flour);
        internal static Item Cheese => GetExistingGDO<Item>(ItemReference.Cheese);
        internal static Item BurntBread => GetExistingGDO<Item>(ItemReferences.BurnedBread);

        internal static Process Cook => GetExistingGDO<Process>(ProcessReferences.Cook);
        internal static Process Chop => GetExistingGDO<Process>(ProcessReferences.Chop);
        internal static Process Knead => GetExistingGDO<Process>(ProcessReferences.Knead);

        internal static Item BreadSlice => GetExistingGDO<Item>(ItemReference.BreadSlice);
        internal static Item CheeseGrated => GetExistingGDO<Item>(ItemReference.CheeseGrated);

        internal static Item BurntGarlicBread => GetModdedGDO<Item, BurntGarlicBread>();
        internal static ItemGroup UncookedGarlicBread => GetModdedGDO<ItemGroup, UncookedGarlicBread>();
        internal static ItemGroup PlatedGarlicBread => GetModdedGDO<ItemGroup, PlatedGarlicBread>();
        internal static Item CookedGarlicBread => GetModdedGDO<Item, CookedGarlicBread>();
        internal static Dish GarlicBreadDish => GetModdedGDO<Dish, GarlicBreadDish>();
        internal static bool debug = true;
        public static void LogInfo(string _log) { Debug.Log($"[{MOD_NAME}] " + _log); }
        public static void LogInfo(object _log) { LogInfo(_log.ToString()); }

        public Mod() : base(MOD_ID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, $"{PLATEUP_VERSION}", Assembly.GetExecutingAssembly())
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
            AddGameDataObject<PlatedGarlicBread>();
            AddGameDataObject<GarlicBreadDish>();
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
    }
}