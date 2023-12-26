using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonRoverForSW
{
    public class RunCourse
    {
        /// <summary>
        /// Checks to see if the two rovers will collide during rover 2 movement.
        /// </summary>
        /// <param name="rover1">Coordinates struct for rover 1</param>
        /// <param name="rover2">Coordinates struct for rover 2</param>
        /// <returns>string if collision, empty string if no collision</returns>
        private string CheckRoverCollision(Coordinates rover1, Coordinates rover2)
        {
            if ((rover1.X == rover2.X) && (rover1.Y == rover2.Y))
                return "Rover collision detected, stopping rover";
            return System.String.Empty;
        }

        /// <summary>
        /// Checks to see if a rover collides with the plateau walls.
        /// </summary>
        /// <param name="plat">Plateau coordinates (height and width)</param>
        /// <param name="rover">Coordinate struct for rover</param>
        /// <returns>string if yes, empty string if no.</returns>
        private string CheckPlateauCollision(Coordinates plat, Coordinates rover)
        {
            if ((plat.X < rover.X) || (plat.Y < rover.Y))
                return "Plateau collision detected, stopping rover";
            return System.String.Empty;
        }

        /// <summary>
        /// Execute is where the logic happens.  It moves the rovers, and returns their final positions
        /// If there are any errors, it will stop moving that rover, log the error, and append the error to the END of the results list
        /// </summary>
        /// <param name="coordinates">List of coordinates for the plateau, and two rovers</param>
        /// <returns>Coordinate list for both rovers, and error in coordinate[2].instructions</returns>
        public List<Coordinates> Execute(List<Coordinates> coordinates)
        {
            Rover rover1 = new Rover(coordinates[1].X, coordinates[1].Y, coordinates[1].dir);
            Rover rover2 = new Rover(coordinates[2].X, coordinates[2].Y, coordinates[2].dir);
            string message = System.String.Empty;
            List<Coordinates> positionList = new List<Coordinates>();
            List<Coordinates> errorList = new List<Coordinates>();

            /*For now, comment out try-catch block, when logging is added, uncomment, and log thrown Exceptions*/
            //try
            //{
            /*Move rover 1*/
            /*Stop if we run into the plateau wall*/
            foreach (char c in coordinates[1].instructions)
            {
                rover1.SetPosition(c.ToString());
                message = CheckPlateauCollision(coordinates[0], rover1.GetPosition());
                if (message != System.String.Empty)
                {
                    Coordinates errorCoords = new Coordinates();
                    errorCoords.instructions = message;
                    errorList.Add(errorCoords);
                    break;
                    //throw new Exception(message);
                }
            }
            
            /*Move rover 2*/
            /*Stop if we run into the plateau wall, or the first rover*/
            foreach (char c in coordinates[2].instructions)
            {
                rover2.SetPosition(c.ToString());
                message = CheckPlateauCollision(coordinates[0], rover2.GetPosition());
                if (message != System.String.Empty)
                {
                    Coordinates errorCoords = new Coordinates();
                    errorCoords.instructions = message;
                    errorList.Add(errorCoords);
                    break;
                    //throw new Exception(message);
                }
                message = CheckRoverCollision(rover1.GetPosition(), rover2.GetPosition());
                if (message != System.String.Empty)
                {
                    Coordinates errorCoords = new Coordinates();
                    errorCoords.instructions = message;
                    errorList.Add(errorCoords);
                    break;
                    //throw new Exception(message);
                }
            }
            positionList.Add(rover1.GetPosition());
            positionList.Add(rover2.GetPosition());
            // In Form1.cs, we count the size of positionList, and if errorList is appended, we grab the last list item and display it
            positionList.AddRange(errorList);
            //}

            //catch (Exception e)
            //{
            //    //TODO:  log this?
            //    return positionList;
            //}
            
            return positionList;
        }
    }
}
