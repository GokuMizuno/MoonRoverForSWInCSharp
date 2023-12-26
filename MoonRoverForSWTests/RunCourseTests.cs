using MoonRoverForSW;

namespace MoonRoverForSWTests
{
    [TestClass]
    public class RunCourseTests
    {
        /// <summary>
        /// Passes two rovers that have the same position, and will move into the same spot.  Will collide
        /// asserts collision data appended to returnCoords as final element
        /// List = rover1, rover2, collision string in coords[2].instructions
        /// </summary>
        [TestMethod]
        public void CheckRoverCollision_WithCollision_Test()
        {
            Coordinates plateau = new Coordinates();
            plateau.X = 5;
            plateau.Y = 5;
            Coordinates r1StartPoint = new Coordinates();
            r1StartPoint.X = 1;
            r1StartPoint.Y = 2;
            r1StartPoint.dir = "E";
            r1StartPoint.instructions = "R";
            Coordinates r2StartPoint = new Coordinates();
            r2StartPoint.X = 1;
            r1StartPoint.Y = 2;
            r2StartPoint.dir = "E";
            r2StartPoint.instructions = "R";

            List<Coordinates> validInput = new List<Coordinates>();
            List<Coordinates> returnedCoords = new List<Coordinates>();
            validInput.Add(plateau);
            validInput.Add(r1StartPoint);
            validInput.Add(r2StartPoint);
            RunCourse rc = new RunCourse();
            returnedCoords = rc.Execute(validInput);

            Assert.AreEqual(3, returnedCoords.Count);
            Assert.AreNotEqual("", returnedCoords[2].instructions);
        }

        /// <summary>
        /// Passes two rovers that will not collide
        /// Asserts there is no collision data appended to returned coordinates
        /// </summary>
        [TestMethod]
        public void CheckRoverCollision_WithoutCollision_Test()
        {
            Coordinates plateau = new Coordinates();
            plateau.X = 5;
            plateau.Y = 5;
            Coordinates r1StartPoint = new Coordinates();
            r1StartPoint.X = 1;
            r1StartPoint.Y = 2;
            r1StartPoint.dir = "E";
            r1StartPoint.instructions = "R";
            Coordinates r2StartPoint = new Coordinates();
            r2StartPoint.X = 0;
            r1StartPoint.Y = 0;
            r2StartPoint.dir = "E";
            r2StartPoint.instructions = "R";
       
            List<Coordinates> validInput = new List<Coordinates>();
            List<Coordinates> returnedCoords = new List<Coordinates>();
            validInput.Add(plateau);
            validInput.Add(r1StartPoint);
            validInput.Add(r2StartPoint);
            RunCourse rc = new RunCourse();
            returnedCoords = rc.Execute(validInput);

            Assert.AreEqual(2, returnedCoords.Count);
        }

        /// <summary>
        /// Tests rover will collide with plateau walls
        /// asserts collision data appended to returnCoords as final element
        /// List = rover1, rover2, collision string in coords[2].instructions
        /// </summary>
        [TestMethod]
        public void CheckPlateauCollsionTest()
        {
            Coordinates plateau = new Coordinates();
            plateau.X = 5;
            plateau.Y = 5;
            Coordinates r1StartPoint = new Coordinates();
            r1StartPoint.X = 1;
            r1StartPoint.Y = 2;
            r1StartPoint.dir = "E";
            r1StartPoint.instructions = "R";
            Coordinates r2StartPoint = new Coordinates();
            r2StartPoint.X = 1;
            r1StartPoint.Y = 2;
            r2StartPoint.dir = "E";
            r2StartPoint.instructions = "MMMMMMMMMM";

            List<Coordinates> validInput = new List<Coordinates>();
            List<Coordinates> returnedCoords = new List<Coordinates>();
            validInput.Add(plateau);
            validInput.Add(r1StartPoint);
            validInput.Add(r2StartPoint);
            RunCourse rc = new RunCourse();
            returnedCoords = rc.Execute(validInput);

            Assert.AreEqual(3, returnedCoords.Count);
            Assert.AreNotEqual("", returnedCoords[2].instructions);
        }

        /// <summary>
        /// Passes two rovers in a list to Execute, and expects two Coordinates in a list back
        /// </summary>
        [TestMethod]
        public void ExecuteTest()
        {
            Coordinates plateau = new Coordinates();
            plateau.X = 5;
            plateau.Y = 5;
            Coordinates r1StartPoint = new Coordinates();
            r1StartPoint.X = 1;
            r1StartPoint.Y = 2;
            r1StartPoint.dir = "E";
            r1StartPoint.instructions = "R";
            Coordinates r2StartPoint = new Coordinates();
            r2StartPoint.X = 0;
            r1StartPoint.Y = 0;
            r2StartPoint.dir = "E";
            r2StartPoint.instructions = "R";

            List<Coordinates> validInput = new List<Coordinates>();
            List<Coordinates> returnedCoords = new List<Coordinates>();
            validInput.Add(plateau);
            validInput.Add(r1StartPoint);
            validInput.Add(r2StartPoint);
            RunCourse rc = new RunCourse();
            returnedCoords = rc.Execute(validInput);

            Assert.AreEqual(2, returnedCoords.Count);

        }
    }
}