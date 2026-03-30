using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygonPlacer
{
    public partial class PolygonPlacer : Form
    {
        //This will dimensions of the 2D plane 
        private int width = 0;
        private int height = 0;

        //This will be the max diemensions of the screen, this will make it so the user cannot make a plane that is bigger then there screen 
        private int maxScreenHeight = 0;
        private int maxScreenWidth = 0;

        //This will be the new form that will have the user show the polygons 
        private Form polygonPlacment;

        public PolygonPlacer()
        {
            InitializeComponent();
        }

        //This will be where all of the gui functions are sotred 
        //-------------------------------------------------------------------------------------------------

        //The main button, once the user enter the diemensions, it will create the plane with the users diemensions 
        private void button1_Click(object sender, EventArgs e)
        {
            height = IntCalculationCheck(HeightBox.Text);
            width = IntCalculationCheck(WidthBox.Text);

            //Check to make sure that the plane has enough diemensions to be seen, then set the diemensions and show the plane
            if (width > 0 && height > 0)
            {
                if (width <= maxScreenWidth && height <= maxScreenHeight)
                {
                    polygonPlacment = new PolygonPlane();
                    polygonPlacment.Width = width;
                    polygonPlacment.Height = height;
                    polygonPlacment.Show();
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
        private void PolygonPlacer_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            //Get the max screen diemensions from the screen 
            maxScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            maxScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;

            WidthBox.Text = maxScreenWidth.ToString();
            HeightBox.Text = maxScreenHeight.ToString();
        }

        private void InstButton_Click(object sender, EventArgs e)
        {
            //This will be the instrcution form for the user 
            InstructionForm instForm = new InstructionForm();
            instForm.Show();
        }


        //This will be where all of the helper functions are stored 
        //--------------------------------------------------------------------------------------------------

        //This will be the function that will check if an input in a text box is an int and if so do it 
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


    }
}
