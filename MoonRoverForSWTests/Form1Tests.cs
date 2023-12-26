using Microsoft.VisualStudio.TestPlatform.Utilities;
using MoonRoverForSW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MoonRoverForSWTests
{
    public class Form1Tests
    {
        [TestMethod]
        public void Form1_public_Test()
        {
            string plateau = "5 5";
            string r1StartPoint = "1 2 N";
            string r2StartPoint = "3 3 E";
            string r1Commands = "LMLMLMLMM";
            string r2Commands = "MMRMMRMRRM";
            string r1Output = "";
            string r2Output = "";
            string errors = "";

            Form1 form1 = new Form1();
            form1.plateau = plateau;
            Assert.AreEqual(form1.plateau, plateau);
            
            /*button1_OnClick method is private, and I am afraid to change it, as I have horrible luck with things like that
              That stuff can be tested from the GUI.
              The code has been copied/pasted below in the OnClickCode tests.
            */
        }

        [TestMethod]
        public void private_Button_OnClickCode_ValidData_Test()
        {
            string plateau = "5 5";
            string r1StartPoint = "1 2 N";
            string r2StartPoint = "3 3 E";
            string r1Commands = "LMLMLMLMM";
            string r2Commands = "MMRMMRMRRM";
            string r1Output = "";
            string r2Output = "";
            string errors = "";

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
            Assert.AreEqual(0, ExceptionList.Count);
            if (ExceptionList.Count > 0)
            {
                string message = string.Join(Environment.NewLine, ExceptionList);
                //MessageBox.Show(message);
            }
            else
            {
                List<Coordinates> returnedCoords = new List<Coordinates>();
                RunCourse runCourse = new RunCourse();
                returnedCoords = runCourse.Execute(validInput);
                r1Output = returnedCoords[0].X.ToString() + " " + returnedCoords[0].Y.ToString() + " " + returnedCoords[0].dir;
                r2Output = returnedCoords[1].X.ToString() + " " + returnedCoords[1].Y.ToString() + " " + returnedCoords[1].dir;
                //Rover1OutputBox.Text = r1Output;
                //Rover2OutputBox.Text = r2Output;
                if (returnedCoords.Count >= 3)  //only display first error message
                {
                    errors = returnedCoords[2].instructions;
                    //ErrorLogBox.Text = errors;
                }
            }
        }

        [TestMethod]
        public void private_Button_OnClickCode_BadData_Test()
        {
            string plateau = "0 -5";
            string r1StartPoint = "-5 a 2";
            string r2StartPoint = "-10 0 E";
            string r1Commands = "q";
            string r2Commands = "MMRMMRMRRM";
            string r1Output = "";
            string r2Output = "";
            string errors = "";

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
            Assert.AreNotEqual(0, ExceptionList.Count);
            if (ExceptionList.Count > 0)
            {
                string message = string.Join(Environment.NewLine, ExceptionList);
                //MessageBox.Show(message);
            }
            else
            {
                List<Coordinates> returnedCoords = new List<Coordinates>();
                RunCourse runCourse = new RunCourse();
                returnedCoords = runCourse.Execute(validInput);
                r1Output = returnedCoords[0].X.ToString() + " " + returnedCoords[0].Y.ToString() + " " + returnedCoords[0].dir;
                r2Output = returnedCoords[1].X.ToString() + " " + returnedCoords[1].Y.ToString() + " " + returnedCoords[1].dir;
                //Rover1OutputBox.Text = r1Output;
                //Rover2OutputBox.Text = r2Output;
                if (returnedCoords.Count >= 3)  //only display first error message
                {
                    errors = returnedCoords[2].instructions;
                    //ErrorLogBox.Text = errors;
                }
            }
        }
    }
}
