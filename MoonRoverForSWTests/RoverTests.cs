using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonRoverForSW;

namespace MoonRoverForSWTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void CreateRoverTest()
        {
            int X = 1;
            int Y = 2;
            string dir = "N";

            Rover rover = new Rover(X, Y, dir);
            Coordinates coordinates = new Coordinates();
            coordinates = rover.GetPosition();
            Assert.AreEqual(X, coordinates.X);
            Assert.AreEqual(Y, coordinates.Y);
            Assert.AreEqual(dir, coordinates.dir);
        }

        [TestMethod]
        public void SetPositionTest()
        {
            Rover rover = new Rover(0, 0, "N");
            Coordinates startCoord = rover.GetPosition();
            rover.SetPosition("M");
            Coordinates finalCoord = rover.GetPosition();
            Assert.AreNotEqual(startCoord, finalCoord);

        }

        [TestMethod]
        public void SetRotation_Left_Test()
        {
            string rot = "L";
            Rover rover = new Rover(0, 0, "N");
            rover.SetPosition(rot);
            Coordinates finalCoord = rover.GetPosition();
            Assert.AreEqual("W", finalCoord.dir);
            rover.SetPosition(rot);
            finalCoord = rover.GetPosition();
            Assert.AreEqual("S", finalCoord.dir);
            rover.SetPosition(rot);
            finalCoord = rover.GetPosition();
            Assert.AreEqual("E", finalCoord.dir);
            rover.SetPosition(rot);
            finalCoord = rover.GetPosition();
            Assert.AreEqual("N", finalCoord.dir);
        }

        [TestMethod]
        public void SetRotation_Right_Test()
        {
            string rot = "R";
            Rover rover = new Rover(0, 0, "N");
            rover.SetPosition(rot);
            Coordinates finalCoord = rover.GetPosition();
            Assert.AreEqual("E", finalCoord.dir);
            rover.SetPosition(rot);
            finalCoord = rover.GetPosition();
            Assert.AreEqual("S", finalCoord.dir);
            rover.SetPosition(rot);
            finalCoord = rover.GetPosition();
            Assert.AreEqual("W", finalCoord.dir);
            rover.SetPosition(rot);
            finalCoord = rover.GetPosition();
            Assert.AreEqual("N", finalCoord.dir);
        }

        [TestMethod]
        public void GetPositionTest()
        {
            int X = 1;
            int Y = 2;
            string dir = "N";

            Rover rover = new Rover(X, Y, dir);
            Coordinates coordinates = new Coordinates();
            coordinates = rover.GetPosition();
            Assert.AreEqual(X, coordinates.X);
            Assert.AreEqual(Y, coordinates.Y);
            Assert.AreEqual(dir, coordinates.dir);
        }

        [TestMethod]
        public void CoordinateStructTest()
        {
            Coordinates coordinate = new Coordinates();
            coordinate.X = 1;
            coordinate.Y = 2;
            coordinate.dir = "N";
            coordinate.instructions = "L";

            Assert.AreEqual((short)1, coordinate.X);
            Assert.AreEqual(2, coordinate.Y);
            Assert.AreNotEqual(null, coordinate.dir);
            Assert.AreNotEqual(null, coordinate.instructions);
        }
    }
}
