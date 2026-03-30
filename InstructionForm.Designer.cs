namespace PolygonPlacer
{
    partial class InstructionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateAPlane = new System.Windows.Forms.Label();
            this.HowCreatePlane = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateAPlane
            // 
            this.CreateAPlane.AutoSize = true;
            this.CreateAPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAPlane.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateAPlane.Location = new System.Drawing.Point(12, 9);
            this.CreateAPlane.Name = "CreateAPlane";
            this.CreateAPlane.Size = new System.Drawing.Size(313, 22);
            this.CreateAPlane.TabIndex = 0;
            this.CreateAPlane.Text = "- How To Create A Drawing Plane";
            // 
            // HowCreatePlane
            // 
            this.HowCreatePlane.AutoSize = true;
            this.HowCreatePlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowCreatePlane.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HowCreatePlane.Location = new System.Drawing.Point(12, 41);
            this.HowCreatePlane.MaximumSize = new System.Drawing.Size(275, 0);
            this.HowCreatePlane.MinimumSize = new System.Drawing.Size(10, 0);
            this.HowCreatePlane.Name = "HowCreatePlane";
            this.HowCreatePlane.Size = new System.Drawing.Size(270, 66);
            this.HowCreatePlane.TabIndex = 1;
            this.HowCreatePlane.Text = "- Simply type in the dimensions you want in the start screen and click the Create" +
    " button.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "- How To Draw A Polygon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.MaximumSize = new System.Drawing.Size(275, 0);
            this.label2.MinimumSize = new System.Drawing.Size(10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 132);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Click anywhere in blank drawing area to open an editor. In This editor you need" +
    " to add the amount of points you would like, how thick the lines should be, and " +
    "the color of the polygon.  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.MaximumSize = new System.Drawing.Size(275, 0);
            this.label3.MinimumSize = new System.Drawing.Size(10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 132);
            this.label3.TabIndex = 4;
            this.label3.Text = "- Once a polygon is drawn, if it intersects with any other polygon the area of in" +
    "tersection will ne bordered and the color will be a mix of the intersected polyg" +
    "on colors.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(476, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "- How To Edit A Polygon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(476, 41);
            this.label5.MaximumSize = new System.Drawing.Size(275, 0);
            this.label5.MinimumSize = new System.Drawing.Size(10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 154);
            this.label5.TabIndex = 6;
            this.label5.Text = "- A polygon can be edited by clicking the polygon, once inside the editor, you ca" +
    "n edit the location of the points (in x,y order), which allows for scaling, rota" +
    "tion and translation of the polygon. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(476, 213);
            this.label6.MaximumSize = new System.Drawing.Size(275, 0);
            this.label6.MinimumSize = new System.Drawing.Size(10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 88);
            this.label6.TabIndex = 7;
            this.label6.Text = "- You can also delete the selected polygon or all of them, but ensure you click t" +
    "he correct button before selecting. ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(476, 321);
            this.label8.MaximumSize = new System.Drawing.Size(275, 0);
            this.label8.MinimumSize = new System.Drawing.Size(10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 88);
            this.label8.TabIndex = 9;
            this.label8.Text = "- The polygon intersection display can be turned off as well, by clicking the che" +
    "ck box and clicking the draw shape button.";
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HowCreatePlane);
            this.Controls.Add(this.CreateAPlane);
            this.Name = "InstructionForm";
            this.Text = "InstructionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateAPlane;
        private System.Windows.Forms.Label HowCreatePlane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}