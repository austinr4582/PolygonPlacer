using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygonPlacer
{
    public partial class PolygonPlane : Form
    {

        //This will be the list of point arrays that will be needed to fill all polygons - different from graphics path as this will store color and thickness 
        private List<CustomPolygon> allPolygons = new List<CustomPolygon>();

        //This will be the editor form that will be spawned when the form is clicked on 
        private EditorForPolygonPlane editorForm;

        //This will be a list to hold the regions and the combined colors of all of the intersections that occur.
        //These are needed in order to have the primary drawing method draw the intersection points around the polygons once the polygons have been drawn 
        private List<Region> interscetRegions = new List<Region>();
        private List<Color> intersectColors = new List<Color>();

        //This will be a bool to check to see intersection if this is true itll visually show intersection, if not true it will not show intersection but still store it 
        public bool showIntersection = true;

        public PolygonPlane()
        {
            InitializeComponent();
        }

        //This will be where all of the gui functions are sotred 
        //-------------------------------------------------------------------------------------------------

        private void PolygonPlane_Load(object sender, EventArgs e)
        {
            //This will size the panel correctly 
            DrawArea.Location = new System.Drawing.Point(0, 0);
            DrawArea.Size = new System.Drawing.Size(this.Width, this.Height);
            DrawArea.BorderStyle = BorderStyle.FixedSingle;

            //Reset the draw panel to make it clear on load
            this.DrawArea.Invalidate();
        }

        //When the base form is clicked it will open the editor for the form, this form will allow for drawing polygons and editing the screen size
        //Using mouse click to get the exact location of where the mouse clicked 
        private void DrawArea_MouseClick(object sender, MouseEventArgs e)
        {
            PolygonEditor(e);
        }

        private void PolygonPlane_MouseClick(object sender, MouseEventArgs e)
        {
            PolygonEditor(e);
        }

        private void DrawArea_Paint(object sender, PaintEventArgs e)
        {
            //Make the graphics object 
            Graphics g = e.Graphics;

            //Int to track colors 
            int colorTrack = 0;

            //This will be the loop to go through every custom made polygon and draw them when needed 
            foreach (CustomPolygon polygon in allPolygons)
            {
                Color tempColor = ColorTranslator.FromHtml(polygon.GetColor());
                //Alpha was at 128 for see through, will remain at 255 to make the intersect area more clear 
                Color color = Color.FromArgb(255, tempColor.R, tempColor.G, tempColor.B);
                using (Pen tempPen = new Pen(color, polygon.GetLineWidth()))
                {
                    using (SolidBrush bursh = new SolidBrush(color))
                    {
                        e.Graphics.DrawPath(tempPen, polygon.GetPoints());
                        e.Graphics.FillPath(bursh, polygon.GetPoints());

                    }
                }
                //Needs to be called in order to create a intersected region 
                IntersectingPolygons(polygon);
            }
            //For loop to go through and highlight all of the intersected regions 
            if (showIntersection)
            {
                foreach (Region interRegion in interscetRegions)
                {
                    //This will be to add a black border around the filled region 
                    GraphicsPath tempPath = new GraphicsPath();
                    tempPath.AddRectangles(interRegion.GetRegionScans(new Matrix()));
                    using (Pen borderArea = new Pen(Color.Black, 2))
                    {
                        using (SolidBrush bursh = new SolidBrush(intersectColors[colorTrack]))
                        {
                            e.Graphics.DrawPath(borderArea, tempPath);
                            e.Graphics.FillRegion(bursh, interRegion);
                        }
                        colorTrack++;
                    }
                }
            }

        }

        //This will be where all of the helper functions are stored 
        //--------------------------------------------------------------------------------------------------
        public Panel GetDrawArea()
        {
            return DrawArea;
        }

        //This method will add a Custom polygon to the list of all polygons 
        public void AddPolygon(String color, int lineWidth, GraphicsPath points, String name)
        {
            CustomPolygon poly = new CustomPolygon(color, lineWidth, points, name);
            allPolygons.Add(poly);
        }

        //Method to create the polygon editor form 
        private void PolygonEditor(MouseEventArgs e)
        {
            foreach (CustomPolygon polygon in allPolygons)
            {
                if (polygon.GetPoints().IsVisible(e.Location))
                {
                    //This will be the editor that is open and editing the forms 
                    EditorForPolygonPlane temp = new EditorForPolygonPlane();
                    temp.Show();
                    temp.SetUpShapeToEdit(polygon);
                    //MessageBox.Show(polygon.GetPoints().PointCount + "");
                    return;
                }
            }
            editorForm = new EditorForPolygonPlane();
            editorForm.Show();
        }

        //This will be a getter to remove the a polygon from the list, used for when a polygon is eidted, removes old version and adds new one 
        public void RemovePolyFromList(CustomPolygon polygon)
        {
            if (allPolygons.Contains(polygon))
            {
                allPolygons.Remove(polygon);
            }
        }

        //This will just get the length of the polygon list 
        public int GetLengthOfPolyList()
        {
            return allPolygons.Count;
        }

        //This class will be able to check if a polygon intersects with other polygons
        //**IMPORTANT**
        //This is my first time using graphics paths and Regions so in this function I over explain the code so I can make sure I can understand what is going on, please forgive the long comments
        public String IntersectingPolygons(CustomPolygon polygon)
        {
            String objectsIntersected = "The polygon intersects with these other polygon(s): ";
            //Make sure that there is enough polygons to warrant the check 
            if (allPolygons.Count > 1)
            {
                foreach (CustomPolygon poly2 in allPolygons)
                {
                    //First check to make sure that it wont count itself 
                    if (polygon.GetPoints() != poly2.GetPoints())
                    {
                        //Make regions of the two to see if there will be an overlap 
                        Region polyReg1 = new Region(polygon.GetPoints());
                        Region polyReg2 = new Region(poly2.GetPoints());
                        //Regions are used here as they are easy to create out of grpahics paths, they are making space out of the bounds polygon that we want to check as well 
                        // as all other polygons that are in the scene, 

                        //This combines the two regions into a region where only the points and lines shared by the regions 
                        // and graphics objects exsist, if they are no overlapping objects it will make an empty region
                        polyReg1.Intersect(polyReg2);

                        //The IsEmpty function is the easiest to check for intersection but needs a graphics object I am making 
                        // a dummy graphics object from a bitmap so we can use that to check to see if the resulting region has value
                        using (Bitmap bit = new Bitmap(1, 1))
                        using (Graphics g = Graphics.FromImage(bit))
                        {
                            //Add the interection to a known list in the polygon editor 
                            if (!polyReg1.IsEmpty(g))
                            {
                                objectsIntersected += " " + poly2.GetName();
                                //Combine the colors of the two polygons to get the intersected area 
                                Color poly1Color = ColorTranslator.FromHtml(polygon.GetColor());
                                Color poly2Color = ColorTranslator.FromHtml(poly2.GetColor());
                                Color combinedPolyColor = CombineColors(poly1Color, poly2Color);
                                interscetRegions.Add(polyReg1);
                                intersectColors.Add(combinedPolyColor);
                            }
                        }
                    }
                }
            }
            return objectsIntersected;
        }


        //This will be a function that will simply delete all of the polygons from the list by using the other remove method 
        public void DeleteAllPolygons()
        {
            foreach (CustomPolygon polygon in allPolygons)
            {
                polygon.GetPoints().Dispose();
            }
            allPolygons.Clear();
        }

        //Just a function to mix colors of polygons
        private Color CombineColors(Color c1, Color c2)
        {
            int r = (c1.R + c2.R) / 2;
            int g = (c1.G + c2.G) / 2;
            int b = (c1.B + c2.B) / 2;

            return Color.FromArgb(r, g, b);
        }

        //This will be a function that will need to be called when delete is in order to clear the intersection list 
        public void clearIntersectRegion()
        {
            interscetRegions.Clear();
            intersectColors.Clear();
        }


    }
}
