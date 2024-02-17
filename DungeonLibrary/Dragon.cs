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
                    Name = "The Emberwing";
                    MaxDamage += 2;
                    MinDamage += 2;
                    Description = "The Emberwing is a majestic creature cloaked in shimmering scales of intense crimson and gold.\n" +
                        "Its massive wings, resembling fiery infernos, fan the air with each beat, leaving trails of sparks in its\n" +
                        "wake. The Emberwing's eyes blaze with an inner flame, reflecting both its destructive power and ancient wisdom.\n";

                }
                else if (value.ToUpper() == "ICE" || value.ToUpper() == "I")
                {
                    dragonType = "Ice";
                    Name = "The White Frostwing";
                    MaxLife += 5;
                    Life += 5;
                    Description = "The White Frostwing boasts radiant white scales that mimic freshly fallen snow,\n" +
                        "intricately adorned with frost patterns. Its colossal, sinuous frame is complemented by\n" +
                        "translucent wings featuring delicate frost veins. The dragon's piercing icy-blue eyes reflect\n" +
                        "ancient wisdom, while its lethal claws and teeth hint at formidable power.\n";

                }
                else if (value.ToUpper() == "WINGED" || value.ToUpper() == "W")
                {
                    dragonType = "Winged";
                    Name = "The Wyrmsoar";
                    Dodge -= 5;
                    MinDamage += 2;
                    Description = "The Wyrmsoar commands the skies with an imposing presence. Its scales shimmer with a metallic luster,\n" +
                        "ranging from deep emerald to obsidian, while mighty wings, expansive and membrane-stretched, grant it unparalleled\n" +
                        "aerial prowess. Glowing, intelligent eyes convey ancient wisdom, and serrated claws and fangs attest to its formidable\n" +
                        "combat capabilities.\n";
                }
                else if (value.ToUpper() == "CHINESE" || value.ToUpper() == "C")
                {
                    dragonType = "Chinese";
                    Name = "The Celestial Serpent";
                    Description = "The Celestial Serpent gracefully weaves through the air with a sinuous, serpentine body adorned in vibrant hues\n" +
                        "of azure, jade, and gold. Its long, majestic whiskers and flowing beard accentuate its wise and benevolent nature, while\n" +
                        "luminous, pearl-like orbs along its back exude an otherworldly radiance.\n";
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
            DragonType = "The dragon commands awe and fear with its majestic presence. Towering at colossal heights,\n" +
                "its scaly hide gleams with a resplendent sheen. The dragon's serpentine neck supports a head crowned\n" +
                "with fearsome horns. With claws that can rend stone and a breath weapon that embodies the essence of its\n" +
                "draconic lineage, the dragon is a formidable force.\n";
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

