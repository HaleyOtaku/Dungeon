using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryLibrary;
using DungeonLibrary;


namespace InventoryLibrary
{
    public sealed class Potion : Item
    {
        //FIELDS

        //PROPERTIES
        public string PotionStrength { get; set; }
        public int PotionHealing { get; set; }

        //COLLECT/CATCH/CONSTRUCTORS
        public Potion(string name, int qty, string description, string objectType, int id,
            string potionStrength) : base(name, qty, description, objectType, id)
        {
            PotionStrength = potionStrength;

            switch (PotionStrength.ToUpper())
            {
                case "LESSER":
                case "L":
                    PotionHealing = 5;
                    break;

                case "BASIC":
                case "B":
                    PotionHealing = 10;


                    break;

                case "GREATER":
                case "G":
                    PotionHealing = 15;
                    break;

                default: break;
            }
        }

        //METHODS

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

