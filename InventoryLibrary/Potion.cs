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

        //COLLECT/CATCH/CONSTRUCTORS
        public Potion(string name, int qty, string description, string objectType,
            string potionStrength) : base(name, qty, description, objectType)
        {
            PotionStrength = potionStrength;

            switch (PotionStrength.ToUpper())
            {
                case "LESSER":
                case "L":

                    break;

                case "BASIC":
                case "B":

                    break;

                case "GREATER":
                case "G":

                    break;

                default: break;
            }
        }

        //METHODS

        public override string ToString()
        {
            return base.ToString();
        }


        public override int GetQty()
        {
            return Qty;
        }

        public static Potion GetPotion()
        {
            Potion p1 = new("Lesser Healing Potion", 1, "Lesser Healing Potion", "Potion", "Lesser");
            Potion p2 = new("Healing Potion", 1, "Basic Healing Potion", "Potion", "Basic");
            Potion p3 = new("Greater Healing Potion", 1, "Greater Healing Potion", "Potion", "Greater");

            List<Potion> potions = new List<Potion>() { p1, p2, p3 };

            int randIndex = new Random().Next(potions.Count);
            Potion potion = potions[randIndex];
            return potion;
        }
    }
}

