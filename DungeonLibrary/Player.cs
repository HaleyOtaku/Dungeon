using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //Properties
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Score { get; set; }

        //Constructors
        public Player(string name, int hitChance, int dodge, int maxLife,
            Race playerRace, Weapon equippedWeapon)
            : base(name, hitChance, dodge, maxLife)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Potential Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Race.Human:
                    Life -= 6;
                    MaxLife -= 6;
                    HitChance += 10;
                    Dodge += 7;
                    break;
                case Race.Orc:
                    break;
                case Race.Elf:
                    Life -= 5;
                    MaxLife -= 5;
                    HitChance += 10;
                    Dodge += 5;
                    break;
                case Race.Halfling:
                    break;
                case Race.Gnome:
                    break;
                case Race.Tabaxi:
                    break;
                case Race.Dwarf:
                    break;
                case Race.Dragonborn:
                    break;
                case Race.Aasimar:
                    break;
                case Race.Harengon:
                    break;
                case Race.Tiefling:
                    break;
                default:
                    break;
            }
            #endregion
        }

     

        //Methods
        public override string ToString()
        {
            return $"---------------{Name}--------------\n" +
                   $"Race: {PlayerRace.ToString().Replace('_', ' ')}\n\n"+
                   $"Life: {Life}/{MaxLife}\n" +
                   $"Hit Chance: {HitChance}%\n" +
                   $"Dodge: {Dodge}%\n" + 
                   $"\nWeapon:\n{EquippedWeapon}\n"
               ;
        }

        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();

            //determine damage
            int damage = rand.Next(EquippedWeapon.MinDamage,
                EquippedWeapon.MaxDamage + 1);

            //return damage
            return damage;
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }




    }
}
