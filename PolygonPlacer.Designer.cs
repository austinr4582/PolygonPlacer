namespace PolygonPlacer
{
    partial class PolygonPlacer
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
            this.button1 = new System.Windows.Forms.Button();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.InstButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(373, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Drawing Plane";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WidthBox
            // 
            this.WidthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthBox.Location = new System.Drawing.Point(627, 150);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(132, 32);
            this.WidthBox.TabIndex = 1;
            this.WidthBox.Text = "1000";
            // 
            // HeightBox
            // 
            this.HeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightBox.Location = new System.Drawing.Point(627, 230);
            this.HeightBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(132, 32);
            this.HeightBox.TabIndex = 2;
            this.HeightBox.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(485, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(485, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Header.Location = new System.Drawing.Point(363, 1);
            this.Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(526, 55);
            this.Header.TabIndex = 5;
            this.Header.Text = "Polygon Drawing Form ";
            // 
            // InstButton
            // 
            this.InstButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.InstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InstButton.Location = new System.Drawing.Point(455, 325);
            this.InstButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InstButton.Name = "InstButton";
            this.InstButton.Size = new System.Drawing.Size(303, 60);
            this.InstButton.TabIndex = 6;
            this.InstButton.Text = "Instructions";
            this.InstButton.UseVisualStyleBackColor = false;
            this.InstButton.Click += new System.EventHandler(this.InstButton_Click);
            // 
            // PolygonPlacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(857, 485);
            this.Controls.Add(this.InstButton);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PolygonPlacer";
            this.Text = "PolygonPlacer";
            this.Load += new System.EventHandler(this.PolygonPlacer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button InstButton;
    }
}

