using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //make it public!
    public class MonsterTemplate : Monster //rename MonsterTemplate to monster subtype
    {
        //FIELDS
        //-- ONLY IF YOU HAVE BUSINESS RULES

        //PROPERTIES
        //! At least one property. These should behave differently in each of your subtypes.

        //Constructors
        public MonsterTemplate(string name, int hitChance, int dodge, int maxLife,
            int maxDamage, int minDamage, string description)
            : base(name, hitChance, dodge, maxLife,maxDamage,minDamage,description)
        {
            //!Add your custom props to the parameter list above and assign them here.
        
        }

        public MonsterTemplate()
        {
            //Assign each of the properties some default value. This is for a weak/baby version of the monster.
            Name = "Monster";
            HitChance = 10;


        }//MonsterTemplate m1 = new MonsterTemplate()

        //Methods

        public override string ToString()
        {
            return base.ToString() + "";
        }

        //!override at least one parent method to change the functionality based on your new property
        //CalcDodge();
        //CalcHitChance();
        //CalcDamage();
    }
}
