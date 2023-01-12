using GarlicBread.Customs.GarlicBreadProcess;
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



namespace GarlicBread
{
    public class Mod : BaseMod
    {
        internal const string MOD_ID = "GarlicBread";
        internal const string MOD_NAME = "Garlic Bread";
        internal const string MOD_VERSION = "0.0.2";
        internal const string MOD_AUTHOR = "Amber Booth";
        internal const string PLATEUP_VERSION = "1.1.2";

        internal static Item BreadSlice => getexsistingGDO<Item>(ItemReference.BreadSlice);
        internal static Item CheeseGrated => getexsistingGDO<Item>(ItemReference.CheeseGrated);
        internal static Item BurntBread => GetExistingGDO<Item>(ItemReferences.BurntBread);

        internal static Process Cook => GetExsiistingGDO<Process>(ProcessReferences.Cook);

        internal static Item BreadSlice => GetModdedGDO<Item, CheeseGrated>();
        internal static Item CheeseGrated => GetModdedGDO<Item, CheeseGrated>();
        internal static Item BurntGarlicBread => GetModdedGDO<Item, BurntGarlicBread>();

        internal static Dish CookedGarlicBread => GetModdedGDO<Dish, CookedGarlicBread>();

        internal static AssetBundle bundle;
        internal static bool debug = true;

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).ToList()[0];
        }

        public Mod() : base(MOD_ID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, $"{PLATEUP_VERSION}", Assembly.GetExecutingAssembly())
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string commons = Uri.UnescapeDataString(uri.Path);
            string steamapps = Directory.GetParent(commons).FullName;
            string workshop = Path.Combine(steamapps, "workshop");
            string content = Path.Combine(workshop, "content");
            string bundlePath = Path.Combine(new string[] { Directory.GetParent(Application.dataPath).FullName, "Mods", ModID });

            Debug.Log($"{MOD_NAME} {MOD_VERSION} {MOD_AUTHOR}: Loaded");
            Debug.Log($"Assets Loaded From {bundlePath}");
        }

        protected override void Initialise()
        {
            base.Initalise();

            AddGameDataObject<GarlicBread>();
            AddGameDataObject<BurntGarlicBread>();
            AddGameDataObject<CookedGarlicBread>();
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