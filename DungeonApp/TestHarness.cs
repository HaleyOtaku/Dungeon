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
            Character Isolde = new Character("Isolde",70,20,100);
            Console.WriteLine(Isolde);
            Weapon w1 = new Weapon("Stick", 0, 1, 0, false, WeaponType.Sword);
            Console.WriteLine(w1);

            Console.WriteLine();
            Weapon w2 = new Weapon("Sword of Azeroth", 5, 10, 3, true, WeaponType.Sword);
            Console.WriteLine(w2);
            Console.WriteLine();

            int x = 42;
            object y = 52;
            y = x;
            y = w1;
            Console.WriteLine(((Weapon)y).Name);
        }
    }
}
