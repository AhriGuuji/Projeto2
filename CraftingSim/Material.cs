using System;
using CraftingSim.Model;

namespace CraftingSim
{
    public class Material : IMaterial
    {
        private int id;
        private string name;

        int IMaterial.Id => id;
        string IMaterial.Name => name;
        
        public Material(int id, string name)
        {
            this.name = name;
            this.id = id;
        }

        public bool Equals(IMaterial other)
        {
            if (id == other.Id || name == other.Name)
            {
                return true;
            }
            else return false;
        }
    }
}