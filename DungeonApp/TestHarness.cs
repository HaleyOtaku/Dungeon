using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonApp
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            #region Characters
            //example character
            Character Isolde = new Character("Isolde",70,20,100);
            //Console.WriteLine(Isolde);
            #endregion

            #region Starter Weapons (not dropped)

            Weapon stick = new Weapon("Stick", 0, 1, 0, false, WeaponType.Sword);  
            Weapon spear = new Weapon("Spear", 0,2,2,true,WeaponType.Ranged);
            Weapon polearm = new Weapon("Polearm", 0, 1, 3, true, WeaponType.Ranged);
            Weapon axe = new Weapon("Axe", 1, 3, 0, true, WeaponType.Hammer);
            Weapon sledgeHammer = new Weapon("Sledgehammer", 2, 4, 0, true, WeaponType.Hammer);
            Weapon staff = new Weapon("Staff",0,3,1,false,WeaponType.Staff);
            Weapon bow = new Weapon("Bow",0,2,2,true,WeaponType.Ranged);
            Weapon crossbow = new Weapon("Crossbow",1,2,1,true,WeaponType.Ranged);
            Weapon dagger = new Weapon("Dagger", 2, 3, 1, false, WeaponType.Knife);
            Weapon spellBook = new Weapon("Spellbook",1,3,0,true,WeaponType.Spell);
            #endregion

            #region Legendary Weapons or Weapon Drops

            Weapon swordOfAzeroth = new Weapon("Sword of Azeroth", 5, 10, 3, true, WeaponType.Sword);   
            Weapon excaliber = new Weapon("Excaliber", 3,11,1, false, WeaponType.Sword);
            Weapon elderWand = new Weapon("The Elder Wand", 5, 9, 4, false, WeaponType.Staff);
            Weapon mjolnir = new Weapon("Mjolnir", 6, 13, 2, true, WeaponType.Hammer);
            Weapon spearVolmar = new Weapon("Volmar's Spear",2,12,1,true,WeaponType.Ranged);
            #endregion

            #region Weapon Selection
            Weapon equippedWeapon;
            bool runWeaponMenu = false;
            bool weaponSelected = false;

            while (weaponSelected != true)
            {
                Console.WriteLine("~.~.~.~.~.~ Weapon Menu ~.~.~.~.~.~");
                Console.WriteLine("\nChoose your weapon, adventurer!\n");
                Console.WriteLine($"1) {stick.Name}\n" +
                                  $"2) {spear.Name}\n" +
                                  $"3) {polearm.Name}\n" +
                                  $"4) {axe.Name}\n" +
                                  $"5) {sledgeHammer.Name}\n" +
                                  $"6) {staff.Name}\n" +
                                  $"7) {bow.Name}\n" +
                                  $"8) {crossbow.Name}\n" +
                                  $"9) {dagger.Name} \n" +
                                  $"10) {spellBook.Name} \n");
           
            int weaponChoice = int.Parse(Console.ReadLine());

                //Stick
                if (weaponChoice == 1)
                {
                    equippedWeapon = (stick);
                    Console.Clear();
                    Console.WriteLine($"---------------Stick Statistics---------------\n\n{stick}");

                    Console.Write("\nWould you like to select Stick as your weapon? (Y/N) ");
                    string stickConfirm = Console.ReadLine().ToUpper();

                    if (stickConfirm == "Y")
                    {
                        Console.WriteLine($"\n{equippedWeapon.Name} was equipped!");
                        weaponSelected = true;
                        //back to main menu
                    }
                    else { weaponSelected = false; Console.Clear(); }
                }
                

               //Spear
               if (weaponChoice == 2)
                {
                    equippedWeapon = spear;
                    Console.Clear();
                    Console.WriteLine($"---------------Spear Statistics---------------\n\n{spear}");
                    Console.Write("\nWould you like to select Spear as your weapon? (Y/N) ");
                    string spearConfirm = Console.ReadLine().ToUpper();

                    if (spearConfirm == "Y")
                    {
                        Console.WriteLine($"\n{equippedWeapon.Name} was equipped!");
                        weaponSelected = true;
                        //back to main menu
                    }
                    else { weaponSelected = false; Console.Clear(); }
                }


                //Polearm
                if (weaponChoice == 3)
                {
                    equippedWeapon = polearm;
                    Console.Clear();
                    Console.WriteLine($"---------------Polearm Statistics---------------\n\n{polearm}");
                    Console.Write("\nWould you like to select Polearm as your weapon? (Y/N) ");
                    string polearmConfirm = Console.ReadLine().ToUpper();

                    if (polearmConfirm == "Y")
                    {
                        Console.WriteLine($"\n{equippedWeapon.Name} was equipped!");
                        weaponSelected = true;
                        //back to main menu
                    }
                    else { weaponSelected = false; Console.Clear(); }

                }
                
                //Axe
                if(weaponChoice == 4)
                {
                    equippedWeapon= axe;
                    Console.Clear();
                    Console.WriteLine($"---------------Axe Statistics---------------\n\n{axe}");
                    Console.Write("\nWould you like to select Axe as your weapon? (Y/N) ");
                    string axeConfirm = Console.ReadLine().ToUpper();

                    if (axeConfirm == "Y")
                    {
                        Console.WriteLine($"\n{equippedWeapon.Name} was equipped!");
                        weaponSelected = true;
                        //back to main menu
                    }
                    else { weaponSelected = false; Console.Clear(); }
                }
                

                //Sledgehammer
                if(weaponChoice == 5)
                {
                    equippedWeapon = sledgeHammer;
                    Console.Clear();
                    Console.WriteLine($"---------------Sledgehammer Statistics---------------\n\n{sledgeHammer}");
                    Console.Write("\nWould you like to select Sledgehammer as your weapon? (Y/N) ");
                    string sledgehammerConfirm = Console.ReadLine().ToUpper();

                    if (sledgehammerConfirm == "Y")
                    {
                        Console.WriteLine($"\n{equippedWeapon.Name} was equipped!");
                        weaponSelected = true;
                        //back to main menu
                    }
                    else { weaponSelected = false; Console.Clear(); }
                }

                //Staff
                if (weaponChoice == 6)
                {
                    equippedWeapon = staff;
                    Console.Clear();
                    Console.WriteLine($"---------------Staff Statistics---------------\n\n{staff}");
                    Console.Write("\nWould you like to select Staff as your weapon? (Y/N) ");
                    string staffConfirm = Console.ReadLine().ToUpper();

                    if (staffConfirm == "Y")
                    {
                        Console.WriteLine($"\n{equippedWeapon.Name} was equipped!");
                        weaponSelected = true;
                        //back to main menu
                    }
                    else { weaponSelected = false; Console.Clear(); }
                }


                //Bow
                if (weaponChoice == 7)
                {
                    equippedWeapon = bow;
                    Console.Clear();
                    Console.WriteLine($"---------------Bow Statistics---------------\n\n{bow}");
                    Console.Write("\nWould you like to select Bow as your weapon? (Y/N) ");
                    string bowConfirm = Console.ReadLine().ToUpper();

                    if (bowConfirm == "Y")
                    {
                        Console.WriteLine($"\n{equippedWeapon.Name} was equipped!");
                        weaponSelected = true;
                        //back to main menu
                    }
                    else { weaponSelected = false; Console.Clear(); }
                }
                

                //Crossbow
                if (weaponChoice == 8) 
                {
                    equippedWeapon = crossbow;
                    Console.Clear();
                    Console.WriteLine($"---------------Crossbow Statistics---------------\n\n{crossbow}");
                    Console.Write("\nWould you like to select Crossbow as your weapon? (Y/N) ");
                    string crossbowConfirm = Console.ReadLine().ToUpper();

                    if (crossbowConfirm == "Y")
                    {
                        Console.WriteLine($"\n{equippedWeapon.Name} was equipped!");
                        weaponSelected = true;
                        //back to main menu
                    }
                    else { weaponSelected = false; Console.Clear(); }
                }


                //Dagger
                if (weaponChoice == 9)
                {
                    equippedWeapon = dagger;
                    Console.Clear();
                    Console.WriteLine($"---------------Dagger Statistics---------------\n\n{dagger}");
                    Console.Write("\nWould you like to select Dagger as your weapon? (Y/N) ");
                    string daggerConfirm = Console.ReadLine().ToUpper();

                    if (daggerConfirm == "Y")
                    {
                        Console.WriteLine($"\n{equippedWeapon.Name} was equipped!");
                        weaponSelected = true;
                        //back to main menu
                    }
                    else { weaponSelected = false; Console.Clear(); }
                }
                


                //Spellbook
                if (weaponChoice == 10)
                {
                    equippedWeapon = spellBook;
                    Console.Clear();
                    Console.WriteLine($"---------------Spellbook Statistics---------------\n\n{spellBook}");
                    Console.Write("\nWould you like to select Spellbook as your weapon? (Y/N) ");
                    string spellbookConfirm = Console.ReadLine().ToUpper();

                    if (spellbookConfirm == "Y")
                    {
                        Console.WriteLine($"\n{equippedWeapon.Name} was equipped!");
                        weaponSelected = true;
                        //back to main menu
                    }
                    else { weaponSelected = false; Console.Clear(); }
                }

            }
            #endregion

        }

    }

    //TODO Move Weapon Selection to its own, referencable class or move to library

    //TODO Inspect Button to Inspect Current Weapon or Inventory Weapon

    //TODO Title Page
    //TODO Main Menu
    //TODO Inventory Menu
    //TODO Make an Inventory (Array) w subclasses or types, like the weapons

}


