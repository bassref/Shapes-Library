/******************************************************************************
 * Name: Rephael Edwards
 * Course: CPMS 4143
 * Instructor: Dr. Stringfellow
 * Program Description: This program uses a library (dll) of shapes to allow 
 *                      the user to obtain calculatons on their selected shape
******************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLibrary;

namespace WorldofShapes
{
    public partial class WorldOfShapes : Form
    {

        string shapeName;
        double firstX, firstY, secX, secY, enteredRadius, height, enteredWidth;
        // dictionary to hold the pictures used
        Dictionary<string, Bitmap> Image_Library = new Dictionary<string, Bitmap>()
        {
            {"circle", WorldofShapes.Properties.Resources.circ},
            {"rectangle", WorldofShapes.Properties.Resources.rect},
            {"square", WorldofShapes.Properties.Resources.sq},
            {"sphere", WorldofShapes.Properties.Resources.sphe},
            {"cube", WorldofShapes.Properties.Resources.cu},
            {"cuboid", WorldofShapes.Properties.Resources.cub},
            {"cylinder", WorldofShapes.Properties.Resources.cyl}
        };

        //Purpose: To initialize the form to be used.
        //Requires: none
        //Returns: none
        public WorldOfShapes()
        {
            InitializeComponent();
            data.Visible = false;
            extraCoord.Visible = false;
            Instruction2.Visible = false;
            Enter.Visible = false;
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Purpose: To process information when submit has been clicked
        //Requires: The user to click submit
        //Returns: none
        private void submit1_Click(object sender, EventArgs e)
        {
            // read in the first set of information entered
            shapeName = inputBox.Text.ToLower();
            // hide the controls not needed
            HideFirstInformation();
            // use the shape name to call the correct switch statement
            chooseShapeProcessor(shapeName);
        }

        //Purpose: To hide control functions that are not needed
        //Requires: none
        //Returns: none
        public void HideFirstInformation()
        {
            Instruction1.Visible = false;
            submit1.Visible = false;
            inputBox.Visible = false;
           // extraCoord.Visible = true;
            Instruction2.Visible = true;
            data.Visible = true;
            Enter.Visible = true;
            pointC.Refresh();
            Instruction2.Refresh();
        }

        //Purpose: To select the shape to be processed based on the name entered
        //Requires: A shape name to be entered
        //Returns: none
        public void chooseShapeProcessor(string shapeName)
        {
            switch (shapeName)
            {
                case "circle":
                    ProcessCircle();
                    break;

                case "square":
                    ProcessSquare();                   
                    break;

                case "rectangle":
                    ProcessRectangle();
                    break;

                case "cube":
                    ProcessSquare();
                    break;

                case "cylinder":
                    ProcessCylinder();
                    break;

                case "sphere":
                    ProcessCircle();
                    break;
                case "cuboid":
                    ProcessCuboid();
                    break;

                default:
                    OutputLabel1.Visible = true;
                    OutputLabel1.Text = String.Format("Invalid Choice!");
                    break;

            }

        }

        //Purpose: To cet the first set of information for the circle
        //Requires: The submit button to be clicked
        //Returns: nothing
        public void ProcessCircle()
        {
            // get the next set of information from the user
            pointC.Refresh();
            Instruction2.Refresh();
            Instruction2.Text = String.Format("Enter the starting coordinates and the radius");
            pointC.Text = String.Format("radius");
            // wait on the user clicks enter call the methods to do the
            // calculations on the circle
        }
        //Purpose: To cet the first set of information for the square
        //Requires: The submit button to be clicked
        //Returns: nothing
        public void ProcessSquare()
        {
           
            pointC.Refresh();
            Instruction2.Refresh();
            Instruction2.Text = String.Format("Enter the X and Y coordinates for the first point \n"
                       + " and any other value for a second point:");
            pointC.Text = String.Format("X2");
            
        }
        //Purpose: To cet the first set of information for the square
        //Requires: The submit button to be clicked
        //Returns: nothing
        public void ProcessRectangle()
        {
            extraCoord.Visible = true;
            pointC.Refresh();
            Instruction2.Refresh();
            Instruction2.Text = String.Format("Enter the X and Y coordinates for the first point \n"
                       + " and any other value for a second point:");
            pointC.Text = String.Format("X2");

        }
        //Purpose: To cet the first set of information for the cylinder
        //Requires: The submit button to be clicked
        //Returns: nothing
        public void ProcessCylinder()
        {
            // get the next set of information from the user
            extraCoord.Visible = true;
            pointC.Refresh();
            pointD.Refresh();
            Instruction2.Refresh();
            Instruction2.Text = String.Format("Enter the starting coordinates" +
                "the radius and the height.");
            pointC.Text = String.Format("radius");
            pointD.Text = String.Format("height");
        }

        //Purpose: To cet the first set of information for the cuboid
        //Requires: The submit button to be clicked
        //Returns: nothing
        public void ProcessCuboid()
        {
            // get the next set of information from the user
            extraCoord.Visible = true;
            pointC.Refresh();
            pointD.Refresh();
            Instruction2.Refresh();
            Instruction2.Text = String.Format("Enter two different x " +
                "coordinates, the width and the height.");
            pointB.Refresh();
            pointB.Text = String.Format("X2");
            pointC.Text = String.Format("width");
            pointD.Text = String.Format("height");
        }




        //Purpose: To Process Information when Enter has been clicked
        //Requires: The user to click enter and the shape previously entered
        //Returns: none
        private void Enter_Click(object sender, EventArgs e)
        {
               try {
                   // get the coordinates for the first point
                   firstX = Double.Parse(pointBox1.Text);
                   firstY = Double.Parse(pointBox2.Text);

                switch (shapeName)
                {
                    case "circle":
                        {
                            enteredRadius = Double.Parse(pointBox3.Text);
                            Circle circle = new Circle(enteredRadius, firstX, firstY, 0, shapeName);
                            // use ToString to output to the output boxes
                            OutputLabel1.Text = circle.ToString();
                            // show the associated picture
                            displayPicture(shapeName);
                        }
                        break;
                    case "square":
                                           
                        secX = Double.Parse(pointBox3.Text);
                        Square square = new Square(firstX, firstY, secX, shapeName);
                        // use ToString to output to the output boxes
                        OutputLabel1.Text = square.ToString();
                        // show the associated picture
                        displayPicture(shapeName);
                        break;

                    case "rectangle":
                        secX = Double.Parse(pointBox3.Text);
                        secY = Double.Parse(pointBox4.Text);
                        ShapesLibrary.Rectangle rectangle = new ShapesLibrary.Rectangle(firstX, firstY, secX, secY, shapeName);                        
                        // use ToString to output to the output boxes
                        OutputLabel1.Text = rectangle.ToString();
                        // show the associated picture
                        displayPicture(shapeName);
                        break;

                    case "cube":
                        secX = Double.Parse(pointBox3.Text);
                        Cube cube = new Cube(firstX, firstY, secX, shapeName);
                        // use ToString to output to the output boxes
                        OutputLabel1.Text = cube.ToString();
                        // show the associated picture
                        displayPicture(shapeName);
                        break;

                    case "cylinder" :
                        enteredRadius = Double.Parse(pointBox3.Text);
                        height = Double.Parse(pointBox4.Text);
                        Cylinder cylinder = new Cylinder(enteredRadius, firstX, firstY, height, shapeName);
                        // use ToString to output to the output boxes
                        OutputLabel1.Text = cylinder.ToString();
                        // show the associated picture
                        displayPicture(shapeName);
                        break;

                    case "sphere":
                        enteredRadius = Double.Parse(pointBox3.Text);
                        Sphere sphere = new Sphere(enteredRadius, firstX, firstY, 0, shapeName);
                        // use ToString to output to the output boxes
                        OutputLabel1.Text = sphere.ToString();
                        // show the associated picture
                        displayPicture(shapeName);
                        break;
                    case "cuboid":
                        enteredWidth = Double.Parse(pointBox3.Text);
                        height = Double.Parse(pointBox4.Text);
                        Cuboid cuboid = new Cuboid(firstX, firstY, enteredWidth, height, shapeName);
                        // use ToString to output to the output boxes
                        OutputLabel1.Text = cuboid.ToString();
                        // show the associated picture
                        displayPicture(shapeName);
                        break;
                    default:
                        OutputLabel1.Visible = true;
                        OutputLabel1.Text = String.Format("Invalid Choice!");
                        break;
                }
            }
            catch (NegativeNumberException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException f)
            {
                MessageBox.Show(" Please fill in all the information needed.");
            }
            pointBox1.Clear();
            pointBox2.Clear();
            pointBox3.Clear();
            pointBox4.Clear();
        }
        public void displayPicture(string name)
        {
            shapePicture.Visible = true;
            shapePicture.Image = Image_Library[shapeName];
        }

        //Purpose: To end the program.
        //Requires: The user to click quit.
        //Returns: none
        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}



