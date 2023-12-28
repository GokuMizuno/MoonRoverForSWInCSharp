using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoonRoverForSW.Rover;

namespace MoonRoverForSW
{
    /// <summary>
    /// The rover is the object we are moving around.  It has position, X, Y, direction, and instructions to move
    /// </summary>
    public partial class Rover
    {
        private Direction rDirection;
        //Array rDirection = new Array();// Array('N', 'E', 'S', 'W');

        private int Rx  { get; set; }
        private int Ry  { get; set; }

        /// <summary>
        /// The rover is the object we are moving around.  It has position, X, Y, direction, and instructions to move
        /// </summary>
        /// <param name="X">int, the X position; should be >= 0</param>
        /// <param name="Y">int, tye Y position; should be >= 0</param>
        /// <param name="D">string, the direction we are pointing, N,E,S,W</param>
        public Rover(int X, int Y, string D) 
        {
            if ((X < 0) || (Y < 0))
                throw new ArgumentOutOfRangeException();
            if (D == null)
                throw new ArgumentNullException();

            Direction dir = new Direction();
            Rx = X;
            Ry = Y;
            if (D == "N") dir = Direction.N;
            else if (D == "E") dir = Direction.E;
            else if (D == "S") dir = Direction.S;
            else if (D == "W") dir = Direction.W;
            rDirection = dir;
        }

        public Direction RDirection { get => rDirection; set => rDirection = value; }

        /// <summary>
        /// Sets the position of the rover.  M is Move forward 1, L, R are rotate Left and Right
        /// </summary>
        /// <param name="instruction">string.  M is move forward 1, L, R are rotate left and right</param>
        public void SetPosition (string instruction)
        {
            if (instruction == "M")
            {
                if (rDirection == Direction.W || rDirection == Direction.E)
                {
                    Rx += (rDirection == Direction.W) ? -1 : 1;
                }
                else
                {
                    Ry += (rDirection == Direction.S) ? -1 : 1;
                }
            }
            else
            {
                SetRotation(instruction);
            }
        }

        /// <summary>
        /// Rotates the rover.  Called by SetPosition()
        /// </summary>
        /// <param name="rotation">string.  M is move forward 1, L, R are rotate left and right</param>
        /// <returns>Direction the rover is pointing: N,E,W,S</returns>
        public Direction SetRotation(string rotation)
        {
            if ((rotation != "L") || (rotation != "R"))
                throw new ArgumentOutOfRangeException();

            Direction rd = RDirection;
            if (rotation == "R")
            {
                switch (rd)
                {
                    case Direction.N:
                        RDirection = Direction.E;
                        break;
                    case Direction.E:
                        RDirection = Direction.S;
                        break;
                    case Direction.S:
                        RDirection = Direction.W;
                        break;
                    case Direction.W:
                        RDirection = Direction.N;
                        break;
                    default:
                        break;
                }
            }
            else if (rotation == "L")
            {
                switch (rd)
                {
                    case Direction.N:
                        RDirection = Direction.W;
                        break;
                    case Direction.E:
                        RDirection = Direction.N;
                        break;
                    case Direction.S:
                        RDirection = Direction.E;
                        break;
                    case Direction.W:
                        RDirection = Direction.S;
                        break;
                    default:
                        break;
                }
            }
            else 
            {
                //This should never be called.  Validation should be done BEFORE this method is called.
                return rDirection;
            }

            return rDirection;
        }

        /// <summary>
        /// Returns the position (X,Y) and direction the rover is facing
        /// </summary>
        /// <returns>Coordinates struct X, Y, and direction</returns>
        public Coordinates GetPosition()
        {
            Direction rd = RDirection;
            Coordinates coordinates = new Coordinates();
            coordinates.X = Rx;
            coordinates.Y = Ry;
            coordinates.dir = rd.ToString();

            return coordinates;
        }
    }
}
