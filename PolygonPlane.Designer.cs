namespace PolygonPlacer
{
    partial class PolygonPlane
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
            this.DrawArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DrawArea
            // 
            this.DrawArea.Location = new System.Drawing.Point(0, 0);
            this.DrawArea.Name = "DrawArea";
            this.DrawArea.Size = new System.Drawing.Size(200, 100);
            this.DrawArea.TabIndex = 0;
            this.DrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawArea_Paint);
            this.DrawArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseClick);
            // 
            // PolygonPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DrawArea);
            this.Name = "PolygonPlane";
            this.Text = "PolygonPlane";
            this.Load += new System.EventHandler(this.PolygonPlane_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PolygonPlane_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawArea;
    }
}