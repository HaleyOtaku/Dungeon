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
        }
    }
}
