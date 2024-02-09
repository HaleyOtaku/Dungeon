using System;
using System.Collections.Generic;
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
            //Put in main (Program) under room initialization for player to pick their weapon and then assign it
            //Can call Weapon.WeaponPickerMethod() in Program to initiate that

            //Do this here or in main
            //Player.equippedWeapon  to make sure weapon is equipped

            //Player player1 = Player.equippedWeapon();

            //if I were to make a getweapon method in the weapon class
            //to get the specific weapon the user picks in the program and set equipped weapon as
            //that weapon, how would I use that method from the weapon class in the program file to do that?
            //I dont know how to call a method from the weapon class and calling the chosen weapon from it
            //to assign it to the player in the program class


            //cw type it out
            //switch into it


            ////////////////////////////////////////////////////
            //Make the enums into an array/list 
            //the default is array

            //List<WeaponType> weaponTypes = Enum.GetValues<WeaponType>().ToList();

            //Console.WriteLine("Weapon Types: ");
            //int index = 1;

            //foreach (WeaponType item in weaponTypes) {

            //    Console.WriteLine($"{index++}) {item}");
            //}

            //Console.Write("Pick a type: ");
            //int.TryParse(Console.ReadLine(), out int choice);

            ////from the collection

            //WeaponType type = weaponTypes[choice - 1];
            //WeaponType type2 = (WeaponType)(choice - 1);

            //Console.WriteLine($"{type}{type2}");

            //Console.Clear();

            //Loot Box - ask if they wanna loot this thing, if yes, put in loot list, if not, exit



            /////////////////////////////////////////////////////////////////////
            //do
            //{
            //    Monster monster = Monster.GetMonster(); //use this format to equip weapon too
            //    Console.WriteLine(monster);
            //    Console.WriteLine(monster.CalcDamage);
            //    Console.ReadLine();
            //} while (true);



        }



        //TODO Move Weapon Selection to its own, referencable class or move to library

        //TODO Inspect Button to Inspect Current Weapon or Inventory Weapon

        //TODO Title Page
        //TODO Main Menu
        //TODO Inventory Menu
        //TODO Make an Inventory (Array) w subclasses or types, like the weapons

    }
}


