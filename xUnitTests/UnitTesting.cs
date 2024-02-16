using DungeonLibrary;
using System.Runtime.InteropServices;
using Xunit.Sdk;

namespace xUnitTests
{
    public class UnitTesting
    {
        [Fact]
        public void Test_BasicMonster()
        {
            //Arrange
            Monster generic = new ();
            bool expected = true;

            //Act
            bool actual;

            if (generic.CalcDamage() > generic.MinDamage && generic.MaxDamage > generic.CalcDamage())
            { actual = true; }
            else { actual = false; }

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_Player()
        {
            //Arrange
            Player player = new();
            bool expected = true;


            //Act
            bool actual;
            player.Life += 20;
            
            if (player.MaxLife == 5 && player.MaxLife == player.Life)
            { actual = true; }
            else { actual = false; }

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}