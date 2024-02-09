using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Make it public, make it a child of Character
    public class Monster : Character
    {
        //FIELDS 
        //Private variable, where info is stored
        private int _minDamage;
        

        //PROPERTIES
        //Gatekeepers or Ushers
        //Ferry info from fields to methods calling it
        //Getting and Setting, between field and whatever called it
        //Always same name as field but PascalCase
        //Don't store info, just store functionality
        //setting is where the rules of fields are made
        public int MaxDamage { get; set; }
        public  string Description { get; set; }

        public int MinDamage {

            get { return _minDamage; }
            set { if (value > 0 && value <= MaxDamage) {
                    _minDamage = value;
                }
                else { _minDamage = 1; }
            
            
            } 
        }

        //CONSTRUCTORS
        //specialized method
        //no return type
        //allows us to build that object using all of the properties
        //initialization 
        public Monster(string name, int hitChance, int dodge, int maxLife,
            int maxDamage, int minDamage, string description)            : base(name, hitChance, dodge, maxLife)

        {
            //MaxDamage must be set before MinDamage
                MaxDamage = maxDamage;
                MinDamage = minDamage;
                Description = description;
        }

        //default ctor for default monsters later
        //If your parent class does not have a parameter list ctor, you CANNOT have one in the child classes.
        public Monster() //:base()
        {
            
        }

        //METHODS
        //Action
        //If we want fields and properties to do something
        //An action of some sort
        public override string ToString()
        {
            return "****************** Monster ******************\n" + base.ToString() +
                $"Damage: {MinDamage} - {MaxDamage}\n" +
                $"Description: {Description}";
        }
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }

        public static Monster GetMonster() 
        {
            //TODO - Come back and customize this list with your own monster subtypes.
            Monster m1 = new("Monster 1", 50, 20, 25, 8, 2, "The First Monster");
            Monster m2 = new("Monster 2", 50, 20, 25, 8, 2, "The Second Monster");
            Monster m3 = new("Monster 3", 50, 20, 25, 8, 2, "The Third Monster");
            Monster m4 = new("Monster 4", 50, 20, 25, 8, 2, "The First Monster");

            List<Monster> monsters = new List<Monster>() { m1,m2,m3,m4};//can put in multiple times if you want certain ones
            //to show up more frequently

            int randomIndex = new Random().Next(monsters.Count);
            Monster monster = monsters[randomIndex];

            return monster;
        }

    }
}

