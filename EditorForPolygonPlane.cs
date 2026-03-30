using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygonPlacer
{
    public partial class EditorForPolygonPlane : Form
    {
        //This will get the drawing polygon plane 
        private PolygonPlane drawingPlaneForm = Application.OpenForms.OfType<PolygonPlane>().FirstOrDefault();

        //Just width and height of diemensions and the max diemensions 
        private int height = 0;
        private int width = 0;
        private int maxScreenHeight = 0;
        private int maxScreenWidth = 0;

        //This will be the varibales needed for drawing the polygons 
        private int lineWidth = 0;
        private int amountOfPoints = 0;
        private String color = "";
        private List<Point> pointLocations = new List<Point>();

        //This is the polygon that will be removed when the user is editing a polygon on the screen, this will be removed when the user is done eidting the new one 
        private CustomPolygon polyToRemove;

        //This is the list of textboxes that will appear when a user generates the amount of points that they want 
        private List<TextBox> pointTextBoxes = new List<TextBox>();



        //This will be where all of the gui functions are sotred
        //-------------------------------------------------------------------------------------------------
        public EditorForPolygonPlane()
        {
            InitializeComponent();
        }

        private void EditorForPolygonPlane_Load(object sender, EventArgs e)
        {
            //Get the max screen diemensions from the screen 
            maxScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            maxScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;

            WhatDoingLabel.Text = "A new polygon is being created. ";

            EnterNameBox.Text = "Polygon " + drawingPlaneForm.GetLengthOfPolyList();

            WidthBox.Text = maxScreenWidth.ToString();
            HeightBox.Text = maxScreenHeight.ToString();
        }
        private void HideIntersection_CheckedChanged(object sender, EventArgs e)
        {
            drawingPlaneForm.showIntersection = !drawingPlaneForm.showIntersection;
            drawingPlaneForm.Invalidate();
        }

        private void ChangeDiemensionsButton_Click(object sender, EventArgs e)
        {
            height = IntCalculationCheck(HeightBox.Text);
            width = IntCalculationCheck(WidthBox.Text);

            //Check to make sure that the plane has enough diemensions to be seen, then set the diemensions and show the plane
            if (width > 0 && height > 0)
            {
                if (width <= maxScreenWidth && height <= maxScreenHeight)
                {
                    drawingPlaneForm.Width = width;
                    drawingPlaneForm.Height = height;
                    drawingPlaneForm.GetDrawArea().Height = height - 10;
                    drawingPlaneForm.GetDrawArea().Width = width - 10;
                }
                else
                {
                    //Give a message showing the max sizes that are allowed
                    MessageBox.Show("The size you entered is too big for your screen, please lower your bounds. Here are your max " +
                         "diemensions Height: " + maxScreenHeight + " Width: " + maxScreenWidth);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid diemensions that are greater than 0. (Positive whole numbers plaese.) ");
            }
        }

        private void PointsButton_Click(object sender, EventArgs e)
        {
            amountOfPoints = IntCalculationCheck(VertexBox.Text);
            if (amountOfPoints > 2 && amountOfPoints < 13)
            {
                //Loop to remove all old textboxes from the form to ensure that we dont have repeat textboxes ontop of each other 
                foreach (TextBox text in pointTextBoxes)
                {
                    text.Dispose();
                }
                pointTextBoxSpawns(amountOfPoints);
            }
            else
            {
                MessageBox.Show("Please ensure that the amount of points is between 3 and 12 and is a whole number");
            }
        }

        //This will call all the needed function to populate the list of values needed to generate the polygons 
        private void ShapeMakeButton_Click(object sender, EventArgs e)
        {
            FillPointsList();
            GetColor();
            GetPolygonThickness();
            if (ValidateShape())
            {
                Point[] tempArray = pointLocations.ToArray();
                GraphicsPath path = new GraphicsPath();
                path.AddPolygon(tempArray);
                drawingPlaneForm.AddPolygon(color, lineWidth, path, EnterNameBox.Text);
                pointLocations.Clear();
                drawingPlaneForm.GetDrawArea().Invalidate();
                this.Close();
            }
            if (polyToRemove != null)
            {
                drawingPlaneForm.RemovePolyFromList(polyToRemove);
            }
        }

        private void DeletePolygon_Click(object sender, EventArgs e)
        {
            if (polyToRemove != null)
            {
                drawingPlaneForm.RemovePolyFromList(polyToRemove);
                drawingPlaneForm.GetDrawArea().Invalidate();
                drawingPlaneForm.clearIntersectRegion();
                this.Close();
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            drawingPlaneForm.DeleteAllPolygons();
            drawingPlaneForm.GetDrawArea().Invalidate();
            drawingPlaneForm.clearIntersectRegion();
            this.Close();
        }

        //This will be where all of the helper functions are stored 
        //--------------------------------------------------------------------------------------------------
        private int IntCalculationCheck(string text)
        {
            if (text != null)
            {
                int result;
                //Check to make sure that the numbers entered are ints and if so set the return to it 
                if (int.TryParse(text, out result))
                {
                    result = int.Parse(text);
                    return result;
                }
            }
            return 0;
        }

        //This will be the function to generate the amount of text boxes needed for each point 
        private void pointTextBoxSpawns(int amount)
        {
            //This will get rid of all the old textboxes when a new value is generated 
            pointTextBoxes.Clear();


            for (int i = 0; i < 2 * amount; i++)
            {
                if (i % 2 == 0)
                {
                    TextBoxPlacement(610, i, "x");
                }
                else
                {
                    TextBoxPlacement(700, i, "y");
                }
            }
        }

        //This will be a helper function to make creating the point values for the polygons easier, the i will be where it is in the for loop 
        private void TextBoxPlacement(int xPost, int i, String xOry)
        {
            //Create the placement and other needed values for the textboxes 
            TextBox newPointBox = new TextBox();
            newPointBox.Font = new Font("Microsoft Sans Serif", 11);
            newPointBox.Text = xOry + $"Point{(i / 2) + 1}";
            newPointBox.Name = $"Point{i}";
            //Create the location and make sure they are evenly spaced appart 
            newPointBox.Location = new Point(xPost, (i / 2 * 25) + 130);
            newPointBox.Size = new Size(75, 10);
            //This will add them to the list and the form to ensure that they exsits 
            this.Controls.Add(newPointBox);
            pointTextBoxes.Add(newPointBox);
        }

        //This will be a set of functions that will mkae the button to generate all of the values needed to draw the polygons easier -----------------------------------
        private void FillPointsList()
        {
            if (pointTextBoxes.Count > 0)
            {
                //Loop through the values now and assign the values entered as possible points in the polygon 
                for (int i = 0; i < pointTextBoxes.Count; i = i + 2)
                {
                    if (int.TryParse(pointTextBoxes[i].Text, out int xVal) && int.TryParse(pointTextBoxes[i + 1].Text, out int yVal))
                    {
                        Point tempPoint = new Point(xVal, yVal);
                        pointLocations.Add(tempPoint);
                    }
                    else
                    {
                        MessageBox.Show("Please ensure that all points are valid inputs (Whole Positive numbers)");
                        pointLocations.Clear();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please generate a shape first");
            }
        }

        private void GetColor()
        {
            if (ColorComboBox.SelectedIndex != -1)
            {
                color = ColorComboBox.Text;
            }
            else
            {
                MessageBox.Show("Please pick a color first");
            }
        }

        private void GetPolygonThickness()
        {
            if (IntCalculationCheck(PolyWidthBox.Text) != 0)
            {
                lineWidth = IntCalculationCheck(PolyWidthBox.Text);
            }
            else
            {
                MessageBox.Show("Please make sure the width is a proper value (Whole number greater then 0");
            }
        }

        private bool ValidateShape()
        {
            if (pointLocations.Count > 0 && color != "" && lineWidth != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please ensure that all polygon inputs are valid. ");
                return false;
            }
        }

        //This is the class that will be called when a polygon is clciekd to be eidted 
        public void SetUpShapeToEdit(CustomPolygon polygon)
        {
            WhatDoingLabel.Text = "You are EDITING a polygon. ";
            polyToRemove = polygon;
            foreach (TextBox text in pointTextBoxes)
            {
                text.Dispose();
            }
            VertexBox.Text = polygon.GetPoints().PointCount.ToString();
            pointTextBoxSpawns(polygon.GetPoints().PointCount);
            //This int will be used to track the textboxs that spawn and ensure the proper value is assigned to them 
            int textBoxTracker = 0;
            for (int i = 0; i < polygon.GetPoints().PointCount; i++)
            {
                //The polygon gets its points for 0 and assigns the x and y values to the appropriate textbox
                pointTextBoxes[textBoxTracker].Text = polygon.GetPoints().PathPoints[i].X.ToString();
                textBoxTracker++;
                pointTextBoxes[textBoxTracker].Text = polygon.GetPoints().PathPoints[i].Y.ToString();
                textBoxTracker++;

            }
            ColorComboBox.Text = polygon.GetColor();
            PolyWidthBox.Text = polygon.GetLineWidth().ToString();
            EnterNameBox.Text = polygon.GetName();
            Overlap.Text = drawingPlaneForm.IntersectingPolygons(polygon);
        }
        //------------------------------------------------------------------------------------------------------------
    }
}
