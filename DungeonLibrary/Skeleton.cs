using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //make it public!
    public sealed class Skeleton : Monster
    {
        //FIELDS
        //-- ONLY IF YOU HAVE BUSINESS RULES
        private string skeletonType;

        //PROPERTIES
        //! At least one property. These should behave differently in each of your subtypes.
        #region Skeleton SubTypes
        public string SkeletonType { 
            get { return skeletonType; }
            set {
                    if(value.ToUpper() == "R" || value.ToUpper() == "RAGGED") 
                    {
                        skeletonType = "Ragged";
                        MaxDamage -= 2;
                        MaxLife -= 2;
                        Life -= 2;
                    }
                    else if (value.ToUpper() == "S" || value.ToUpper() == "STURDY")
                    {
                         skeletonType = "Sturdy";
                         MaxDamage += 2;
                         MaxLife += 2;
                         Life += 2;
                } else 
                    { skeletonType = ""; }
            }
        }
        #endregion


        //Constructors
        public Skeleton(string name, int hitChance, int dodge, int maxLife,
            int maxDamage, int minDamage, string description, string skeletonType)
            : base(name, hitChance, dodge, maxLife,maxDamage,minDamage,description)
        {
            //!Add your custom props to the parameter list above and assign them here.
            SkeletonType = skeletonType;
        }

        public Skeleton()
        {
            //Assign each of the properties some default value. This is for a weak/baby version of the monster.
            MaxLife = 20;
            MaxDamage = 6;
            Name = "Skeleton";
            Life = 20;
            HitChance = 30;
            Dodge = 2;
            MinDamage = 1;
            Description = "The Skeleton";
            SkeletonType = "";


        }
        //Methods


        public override int CalcDodge()
        {
            return base.CalcDodge()+1;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance()-1;
        }

        public override int CalcDamage()
        {
            return base.CalcDamage()-1;
        }

        public override string ToString()
        {
            return $"****************** {SkeletonType} Skeleton ******************\n" + $"Life: {Life}/{MaxLife}\n" +
                   $"Hit Chance: {HitChance}%\n" +
                   $"Dodge: {Dodge}%\n" + $"Damage: {MinDamage} - {MaxDamage}\n" + $"Skeleton Type: {SkeletonType}\n" +
                   $"Description: {Description}";
        }

        public static Skeleton GetSkeleton()
        {
            #region Skeletons
            Skeleton regSkeleton = new Skeleton();
            Skeleton raggedSkeleton = new Skeleton("Ragged Skeleton", 30, 2, 20, 6, 1, "Ragged Skeleton...", "R");
            Skeleton sturdySkeleton = new Skeleton("Sturdy Skeleton", 30, 2, 20, 6, 1, "Sturdy", "S");
            #endregion

            List<Skeleton> skeletons = new List<Skeleton>()
            {regSkeleton,regSkeleton,regSkeleton,regSkeleton,regSkeleton,
            raggedSkeleton,raggedSkeleton,raggedSkeleton,
            sturdySkeleton, sturdySkeleton
            };//can put in multiple times if you want certain ones
            //to show up more frequently

            int randomIndex = new Random().Next(skeletons.Count);
            Skeleton skeleton = skeletons[randomIndex];

            return skeleton;
        }

        //!override at least one parent method to change the functionality based on your new property
        //CalcDodge();
        //CalcHitChance();
        //CalcDamage();
    }
}
