namespace MoonRoverForSW
{
    /// <summary>
    /// Enum listing directions.  North, East, South, and West.
    /// Can be cast to string for comparisons
    /// </summary>
    public partial class Rover
    {
        public enum Direction { N, E, S, W };

    }

    /// <summary>
    /// The workhorse of the program.
    /// Coordinates carries all the data for the plateau, rovers, and errors
    /// </summary>
    public partial struct Coordinates
    {
        public int X;
        public int Y;
        public string dir;
        public string instructions;
    }
}
