using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //make it public!
    public sealed class Goblin : Monster //rename MonsterTemplate to monster subtype
    {
        //FIELDS
        //-- ONLY IF YOU HAVE BUSINESS RULES
        public string goblinType;

        //PROPERTIES
        //! At least one property. These should behave differently in each of your subtypes.
        #region Goblin SubTypes
        public string GoblinType
        {
            get { return goblinType; }
            set
            {
                if (value.ToUpper() == "S" || value.ToUpper() == "SENSITIVE")
                {
                    goblinType = "Sensitive";
                    MaxDamage -= 3;
                    MaxLife += 3;
                    Life += 3;
                }
                else if (value.ToUpper() == "L" || value.ToUpper() == "LEADER")
                {
                    goblinType = "Leader";
                    MaxDamage += 3;
                    MaxLife += 5;
                    Life += 5;
                }
                else
                { goblinType = ""; }
            }
        }
        #endregion


        //Constructors
        public Goblin(string name, int hitChance, int dodge, int maxLife,
            int maxDamage, int minDamage, string description,
            string goblinType)
            : base(name, hitChance, dodge, maxLife,maxDamage,minDamage,description)
        {
            //!Add your custom props to the parameter list above and assign them here.
            GoblinType = goblinType;
        }

        public Goblin()
        {
            //Assign each of the properties some default value. This is for a weak/baby version of the monster.
            MaxLife = 30;
            MaxDamage = 8;
            Name = "Goblin";
            Life = 30;
            HitChance = 25;
            Dodge = 3;
            MinDamage = 3;
            Description = "The Goblin";
            GoblinType = "Common";
        }

        //Methods


        public override int CalcDamage()
        {
            return base.CalcDamage();
        }

        public override int CalcDodge()
        {
            return base.CalcDodge();
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance()+3;
        }

        public override string ToString()
        {
            return $"****************** {GoblinType} Goblin ******************\n" + $"Life: {Life}/{MaxLife}\n" +
                   $"Hit Chance: {HitChance}%\n" +
                   $"Dodge: {Dodge}%\n" + $"Damage: {MinDamage} - {MaxDamage}\n" + $"Goblin Type: {GoblinType}\n" +
                   $"Description: {Description}";
        }

        public static Goblin GetGoblin()
        {
            #region Goblins
            Goblin regGoblin = new Goblin();
            Goblin senGoblin = new Goblin("Sensitive Goblin", 25, 3, 30, 8, 3, "Sensitive Goblin...", "S");
            Goblin leadGoblin = new Goblin("Lead Goblin", 25, 3, 30, 8, 3, "Lead Goblin...", "L");
            #endregion

            List<Goblin> goblins = new List<Goblin>()
            { regGoblin,regGoblin, regGoblin, regGoblin,regGoblin,
            senGoblin,senGoblin,senGoblin,senGoblin,
            leadGoblin,leadGoblin,leadGoblin
            };//can put in multiple times if you want certain ones
            //to show up more frequently

            int randomIndex = new Random().Next(goblins.Count);
            Goblin goblin = goblins[randomIndex];

            return goblin;
        }

        //!override at least one parent method to change the functionality based on your new property
        //CalcDodge();
        //CalcHitChance();
        //CalcDamage();
    }
}
