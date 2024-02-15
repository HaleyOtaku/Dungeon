using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DungeonLibrary
{
    public sealed class Dragon : Monster
    {

        //FIELDS
        private string dragonType;

        //PROPERTIES
        #region Dragon Sub-Types
        public string DragonType
        {

            get { return dragonType; }

            set
            {
                if (value.ToUpper() == "FIRE" || value.ToUpper() == "F")
                {
                    dragonType = "Fire";
                    MaxDamage += 2;
                    MinDamage += 2;

                }
                else if (value.ToUpper() == "ICE" || value.ToUpper() == "I")
                {
                    dragonType = "Ice";
                    MaxLife += 5;
                    Life += 5;

                }
                else if (value.ToUpper() == "WINGED" || value.ToUpper() == "W")
                {
                    dragonType = "Winged";
                    Dodge -= 5;
                    MinDamage += 2;
                }
                else if (value.ToUpper() == "CHINESE" || value.ToUpper() == "C")
                {
                    dragonType = "Chinese";

                }
                else { dragonType = ""; }
            }

        }
        #endregion

        //CONSTRUCTORS
        public Dragon(string name, int hitChance, int dodge, int maxLife,
            int maxDamage, int minDamage, string description, 
            string dragonType) 
            : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description)
        {
            DragonType = dragonType;
            
        }
       
        public Dragon() 
        {
            MaxLife = 60;
            MaxDamage = 10;
            Name = "Dragon";
            Life = 40;
            HitChance = 20;
            Dodge = 5;
            MinDamage = 2;
            Description = "The Dragon";
            DragonType = "";
        }


        //METHODS
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 2);
        }

        public override int CalcDodge()
        {
            return base.CalcDodge()-2;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance();
        }



        public override string ToString()
        {
            return $"****************** {DragonType} Dragon ******************\n" + $"Life: {Life}/{MaxLife}\n" +
                   $"Hit Chance: {HitChance}%\n" +
                   $"Dodge: {Dodge}%\n" + $"Damage: {MinDamage} - {MaxDamage}\n" + $"Dragon Type: {DragonType}\n" +
                   $"Description: {Description}";
        }

        public static Dragon GetDragon()
        {
            #region Dragons
            Dragon regDragon = new Dragon();
            Dragon iceDragon = new Dragon("Ice Dragon", 20, 5, 60, 10, 2, "Ice Dragon", "I");
            Dragon fireDragon = new Dragon("Fire Dragon", 20, 5, 60, 10, 2, "Fire Dragon", "F");
            Dragon wingedDragon = new Dragon("Winged Dragon", 20, 5, 60, 10, 2, "Winged Dragon", "W");
            Dragon chineseDragon = new Dragon("Chinese Dragon", 20, 5, 60, 10, 2, "Chinese Dragon", "C");
            #endregion

            List<Dragon> dragons = new List<Dragon>()
            {regDragon,regDragon,regDragon,regDragon,regDragon,
            wingedDragon,wingedDragon,wingedDragon,
            chineseDragon, chineseDragon,chineseDragon,
            iceDragon,iceDragon,
            fireDragon,fireDragon
            };//can put in multiple times if you want certain ones
            //to show up more frequently

            int randomIndex = new Random().Next(dragons.Count);
            Dragon dragon = dragons[randomIndex];

            return dragon;
        }
    }
}

