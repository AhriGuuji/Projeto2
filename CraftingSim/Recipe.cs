using System;
using System.Collections.Generic;
using CraftingSim.Model;

namespace CraftingSim
{
    public class Recipe : IRecipe
    {
        private string name;
        private double successRate;
        private IReadOnlyDictionary<IMaterial, int> requiredItems;

        string IRecipe.Name => name;
        double IRecipe.SuccessRate => successRate;
        IReadOnlyDictionary<IMaterial, int> IRecipe.RequiredMaterials => requiredItems;


        public Recipe(string name, IReadOnlyDictionary<IMaterial, int> requiredItems, double successRate)
        {
            this.name = name;
            this.successRate = successRate;
            this.requiredItems = requiredItems;
        }

        public int CompareTo(IRecipe other)
        {
            return name.CompareTo(other.Name);
        }
    }
}