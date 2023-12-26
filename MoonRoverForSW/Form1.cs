using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonRoverForSW
{
    public partial class Form1 : Form
    {
        public string plateau = System.String.Empty;
        string r1StartPoint = System.String.Empty;
        string r2StartPoint = System.String.Empty;
        string r1Commands = System.String.Empty;
        string r2Commands = System.String.Empty;
        string r1Output = System.String.Empty;
        string r2Output = System.String.Empty;
        string errors = System.String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Do validation here, and if all is kosher, then pass a list of strings to doRun()
        /// If invalid, display messagebox with errors, and do not continue until fixed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<Coordinates> validInput = new List<Coordinates>();
            List<string> ExceptionList = new List<string>();
            string allowableLetters = "LMR";

            /*Plateau*/
            try
            {
                Coordinates pcoord = new Coordinates();
                var nums = plateau.Split(' ')?.Select(Int32.Parse)?.ToList();
                if (nums.Count == 2)
                {
                    nums.ToList();
                    pcoord.X = nums[0];
                    pcoord.Y = nums[1];
                    pcoord.dir = System.String.Empty;
                    pcoord.instructions = System.String.Empty;

                    if ((pcoord.X > 0) && (pcoord.Y > 0) && (pcoord.X < Int32.MaxValue) && (pcoord.Y < Int32.MaxValue))
                    {
                        validInput.Add(pcoord);
                    }
                    else
                        throw new Exception("Invalid coordinate in plateau");
                }
                else
                {
                    throw new Exception("Invalid number of coordinates in plateau");
                }
            }
            catch (Exception ex)
            {
                ExceptionList.Add(ex.Message);
            }
            
            /*Rover 1*/
            try
            {
                string[] blah = r1StartPoint.Split(' ');
                Coordinates r1coord = new Coordinates();
                if (blah.Count() == 3)
                {
                    r1coord.X = Int32.Parse(blah[0]);
                    r1coord.Y = Int32.Parse(blah[1]);
                    r1coord.dir = blah[2];
                    r1coord.instructions = System.String.Empty;

                    r1Commands = r1Commands.ToUpper();
                    bool validCommands = r1Commands.All(c => allowableLetters.Contains(c));
                    if (validCommands)
                        r1coord.instructions = r1Commands;
                    else
                        throw new Exception("Bad command in Rover 1 commands");

                    if ((r1coord.X > 0) && (r1coord.Y > 0) && (r1coord.X < Int32.MaxValue) && (r1coord.Y < Int32.MaxValue))
                    {
                        validInput.Add(r1coord);
                    }
                    else
                        throw new Exception("Invalid start coordinates in Rover 1");
                }
                else
                {
                    throw new Exception("Invalid number of coordinates in Rover 1");
                }
            }
            catch (Exception ex)
            {
                ExceptionList.Add(ex.Message);
            }

            /*Rover 2*/
            try
            {
                string[] blah = r2StartPoint.Split(' ');//?.Select(Int32.Parse)?.ToList();
                Coordinates r2coord = new Coordinates();
                if (blah.Count() == 3)
                {
                    r2coord.X = Int32.Parse(blah[0]);
                    r2coord.Y = Int32.Parse(blah[1]);
                    r2coord.dir = blah[2];
                    r2coord.instructions = System.String.Empty;

                    r2Commands = r2Commands.ToUpper();
                    bool validCommands = r2Commands.All(c => allowableLetters.Contains(c));
                    if (validCommands)
                        r2coord.instructions = r2Commands;
                    else
                        throw new Exception("Bad command in Rover 2 commands");

                    if ((r2coord.X > 0) && (r2coord.Y > 0) && (r2coord.X < Int32.MaxValue) && (r2coord.Y < Int32.MaxValue))
                    {
                        validInput.Add(r2coord);
                    }
                    else
                        throw new Exception("Invalid start coordinates in Rover 2");
                }
                else
                {
                    throw new Exception("Invalid number of coordinates in Rover 2");
                }
            }
            catch (Exception ex)
            {
                ExceptionList.Add(ex.Message);
            }

            /*Exception List*/
            if (ExceptionList.Count > 0)
            {   
                string message = string.Join(Environment.NewLine, ExceptionList);
                MessageBox.Show(message);
            }
            else
            {
                List<Coordinates> returnedCoords = new List<Coordinates>();
                RunCourse runCourse = new RunCourse();
                returnedCoords = runCourse.Execute(validInput);
                r1Output = returnedCoords[0].X.ToString() + " " + returnedCoords[0].Y.ToString() + " " + returnedCoords[0].dir;
                r2Output = returnedCoords[1].X.ToString() + " " + returnedCoords[1].Y.ToString() + " " + returnedCoords[1].dir;
                Rover1OutputBox.Text = r1Output;
                Rover2OutputBox.Text = r2Output;
                if (returnedCoords.Count >= 3)  //only display first error message
                {
                    errors = returnedCoords[2].instructions;
                    ErrorLogBox.Text = errors;
                }
            }

        }

        private void PlateauSize_TextChanged(object sender, EventArgs e)
        {
            plateau = PlateauSize.Text.ToString();
            plateau = plateau.Trim();
        }

        private void Rover1StartCoordsBox_TextChanged(object sender, EventArgs e)
        {
            r1StartPoint = Rover1StartCoordsBox.Text.ToString();
            r1StartPoint = r1StartPoint.Trim();
        }

        private void Rover1PathBox_TextChanged(object sender, EventArgs e)
        {
            r1Commands = Rover1PathBox.Text.ToString();
            r1Commands = r1Commands.Trim();
        }

        private void Rover2StartCoordsBox_TextChanged(object sender, EventArgs e)
        {
            r2StartPoint = Rover2StartCoordsBox.Text.ToString();
            r2StartPoint = r2StartPoint.Trim();
        }

        private void Rover2PathBox_TextChanged(object sender, EventArgs e)
        {
            r2Commands = Rover2PathBox.Text.ToString();
            r2Commands = r2Commands.Trim();
        }

        private void Rover1OutputBox_TextChanged(object sender, EventArgs e)
        {
            Rover1OutputBox.Text = r1Output;
        }

        private void Rover2OutputBox_TextChanged(object sender, EventArgs e)
        {
            Rover2OutputBox.Text = r2Output;
        }

        private void ErrorLogBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
