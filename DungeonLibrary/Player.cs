﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
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

            #region Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Race.Human:
                    Life -= 6;
                    MaxLife -= 6;
                    HitChance += 10;
                    Dodge += 7;
                    break;
                case Race.Orc:
                    Life += 6;
                    MaxLife += 6;
                    HitChance += 2;
                    Dodge -= 3;
                    break;
                case Race.Elf:
                    Life -= 5;
                    MaxLife -= 5;
                    HitChance += 10;
                    Dodge += 5;
                    break;
                case Race.Halfling:
                    Life += 3;
                    MaxLife += 3;
                    HitChance -= 10;
                    Dodge += 7;
                    break;
                case Race.Gnome:
                    Life += 2;
                    MaxLife += 2;
                    HitChance -= 7;
                    Dodge += 7;
                    break;
                case Race.Tabaxi:
                    Life -= 2;
                    MaxLife -= 2;
                    HitChance += 5;
                    Dodge += 2;
                    break;
                case Race.Dwarf:
                    Life += 10;
                    MaxLife += 10;
                    HitChance -= 4;
                    Dodge -= 2;
                    break;
                case Race.Dragonborn:
                    Life += 5;
                    MaxLife += 5;
                    HitChance += 2;
                    Dodge -= 3;
                    break;
                case Race.Aasimar:
                    Life += 2;
                    MaxLife += 2;
                    HitChance += 1;
                    Dodge -= 3;
                    break;
                case Race.Harengon:
                    Life += 0;
                    MaxLife += 0;
                    HitChance += 5;
                    Dodge += 10;
                    break;
                case Race.Tiefling:
                    Life += 0;
                    MaxLife += 0;
                    HitChance += 7;
                    Dodge += 3;
                    break;
                case Race.Half_Elf:
                    Life -= 5;
                    MaxLife -= 5;
                    HitChance += 10;
                    Dodge += 7;
                    break;
                case Race.Half_Orc:
                    Life += 5;
                    MaxLife += 5;
                    HitChance -= 3;
                    Dodge += 1;
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
                   $"\nWeapon: {EquippedWeapon}\n"
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
