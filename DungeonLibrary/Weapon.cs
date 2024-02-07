using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{   
    //make it public!
    public class Weapon
    {
        //FIELDS
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;

        //PROPERTIES
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }


        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }

        }

        public string Name 
        { 
            get { return _name; } 
            set {  _name = value; } 
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance;}
            set { _bonusHitChance = value; }
        }


        public bool IsTwoHanded 
        {
            get { return _isTwoHanded;}
            set { _isTwoHanded = value;}
        }

        public WeaponType Type 
        {
            get { return _type; }
            set { _type = value; }
        }

        //COLLECT/CATCH/CONSTRUCTORS
        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            if(minDamage >= maxDamage)
            {
                throw new ArgumentException("Min Damage must be less than max damage.");//custom error
            }

            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
        }






        //METHODS
        public override string ToString()
        {
            //return base.ToString();
            return $"{Name}\n" +
                $"Damage: {MinDamage} - {MaxDamage}\n" +
                $"Bonus Hit: {BonusHitChance}\n" +
                $"{(IsTwoHanded ? "Two" : "One")}-Handed {Type}";
        }
    }
}

