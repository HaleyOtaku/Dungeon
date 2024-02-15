using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            return $"{Name}\n" +
                $"Damage: {MinDamage} - {MaxDamage}\n" +
                $"Bonus Hit: {BonusHitChance}\n" +
                $"{(IsTwoHanded ? "Two" : "One")}-Handed {Type}";
        }


        public static Weapon GetWeapon() 
        {
            int index = 1;

            Weapon stick = new("Stick", 1, 5, 5, false, WeaponType.Sword);
            Weapon longSword = new Weapon("Longsword", 5, 10, 5, true, WeaponType.Sword);
            Weapon staff = new("Tree Branch", 2, 7, 2, false, WeaponType.Staff);
            Weapon fireBall = new("Scroll of FireBall", 3, 10, 8, true, WeaponType.Spell);
            Weapon hammer = new("Mallet", 5, 7, 3, true, WeaponType.Hammer);
            Weapon bowAndArrow = new("Bow and Arrow", 1, 7, 7, true, WeaponType.Ranged);
            Weapon dagger = new("Dagger", 2, 5, 4, false, WeaponType.Knife);

            List <Weapon> weapons = new List<Weapon>() {stick,longSword,staff,fireBall,hammer,bowAndArrow,dagger};
            foreach (Weapon item in weapons)
            {
                Console.WriteLine($"{index++}) {item.Name}");
            }
            Console.WriteLine();

            //readline
            int.TryParse(Console.ReadLine(), out int choice); //1-7


            //if statement - if true return if not, return getweapon
            if (choice > 0 && choice < 7)
            { 
                return weapons[choice - 1];
            }
            else {return GetWeapon();}
        }

        //For Loot
        public static Weapon GetLegendaryWeapon()
        {
            Weapon excaliber = new("Excaliber", 10, 17, 5, false, WeaponType.Sword);
            Weapon mythCarver = new("MythCarver", 10, 13, 10, true, WeaponType.Sword);
            Weapon mjolnir = new Weapon("Mjolnir", 12, 15, 3, true, WeaponType.Hammer);
            Weapon enchiridion = new("Enchiridion of Epictetus", 13, 13, 0, true, WeaponType.Spell);
            Weapon  flameWhip = new("The Whip of Endless Flame", 11, 15, 5, false, WeaponType.Ranged);
            Weapon fenthras = new("The Bow of Fenthras", 10, 15, 8, true, WeaponType.Ranged);
            Weapon leiLang = new("Sacred War Hammer of Lei Lang", 12, 15, 2, true, WeaponType.Hammer);
            Weapon taiLungSword = new("Tai Lung's Sword", 10, 18, 2, false, WeaponType.Sword);
            Weapon dengWa = new("Dagger of Deng Wa", 5, 18, 6, false, WeaponType.Knife);
            Weapon ironFist = new("Iron Fist of Justice", 9, 16, 2, false, WeaponType.Hammer);

            List<Weapon> legWeapons = new List<Weapon>()
            {excaliber,mythCarver,mjolnir,enchiridion,flameWhip,fenthras,leiLang,taiLungSword,dengWa,ironFist};

            int randomIndex = new Random().Next(legWeapons.Count);
            Weapon legWeapon = legWeapons[randomIndex];

            return legWeapon;

        }

    }
}


