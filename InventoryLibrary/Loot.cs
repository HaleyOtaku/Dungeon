using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{//wanted to pull other classes in library into a randomized list in this class, and getloot when monster killed
 //and ask if want to add to inventory then add to inventory, one item at a time, as I wanted to the loot to drop
 //(one per battle, like old pixel games like Zelda), and then ask before using item in inventory (potions, maybe switching equipped weapon to new weapon))
    public sealed class Loot

    {
        //FIELDS
        public static Random rnd = new Random();

        //PROPERTIES

        //COLLECT/CATCH/CONSTRUCTORS

        //METHODS
        public static Loot GetLoot()
        {
            //var potion = Potion.GetPotion();

            var legWeapon = Weapon.GetLegendaryWeapon();

            var regWeapon = Weapon.GetWeapon();


            List<Loot> dropLoot = new List<Loot>()
            {
                //potion,legWeapon,regWeapon
            };

            int randomIndex = new Random().Next(dropLoot.Count);
            Loot loot = dropLoot[randomIndex];
            return loot;
        }




    }
}


