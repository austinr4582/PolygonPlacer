using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
    PolygonPlacer
{
    //This class is meant to server as a way for the panel form to store a list of polygons, and have each one be customizible based on what the user wants 
    public class CustomPolygon
    {

        private String thisColor;
        private int thisLineWidth;
        private GraphicsPath thisPoints = new GraphicsPath();
        private String thisName = ""; 
        public CustomPolygon(String color, int lineWidth, GraphicsPath points, string name)
        {
            thisColor = color;
            thisLineWidth = lineWidth;
            thisPoints = points;
            thisName = name;
        }

        //This will be a getter and setter for all of the values of the CustomPolygon class 
        public String GetColor()
        {
            return thisColor;
        }
        public int GetLineWidth()
        {
            return thisLineWidth;
        }
        public GraphicsPath GetPoints()
        {
            return thisPoints;
        }

        public String GetName()
        {
            return thisName;
        }
        public void SetColor(String color)
        {
            thisColor = color;
        }
        public void SetLineWidth(int lineWidth)
        {
            thisLineWidth = lineWidth;
        }
        public void SetPoints(GraphicsPath points)
        {
            thisPoints = points;
        }

        public void SetName(String name)
        {
            thisName = name;
        }




    }
}
