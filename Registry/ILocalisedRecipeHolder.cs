using KitchenData;
using System.Collections.Generic;

namespace GarlicBreadMod.Registry
{
    public interface ILocalisedRecipeHolder
    {
        IDictionary<Locale, string> LocalisedRecipe { get; }

    }
}