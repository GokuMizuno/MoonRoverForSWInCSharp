namespace MoonRoverForSW
{
    partial class Form1
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
            this.PlateauSize = new System.Windows.Forms.TextBox();
            this.Rover1StartCoordsBox = new System.Windows.Forms.TextBox();
            this.Rover1PathBox = new System.Windows.Forms.TextBox();
            this.Rover2StartCoordsBox = new System.Windows.Forms.TextBox();
            this.Rover2PathBox = new System.Windows.Forms.TextBox();
            this.Rover1OutputBox = new System.Windows.Forms.TextBox();
            this.Rover2OutputBox = new System.Windows.Forms.TextBox();
            this.ErrorLogBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlateauSize
            // 
            this.PlateauSize.Location = new System.Drawing.Point(60, 36);
            this.PlateauSize.Name = "PlateauSize";
            this.PlateauSize.Size = new System.Drawing.Size(100, 20);
            this.PlateauSize.TabIndex = 1;
            this.PlateauSize.Text = "Plateau Size";
            this.PlateauSize.TextChanged += new System.EventHandler(this.PlateauSize_TextChanged);
            // 
            // Rover1StartCoordsBox
            // 
            this.Rover1StartCoordsBox.Location = new System.Drawing.Point(60, 122);
            this.Rover1StartCoordsBox.Name = "Rover1StartCoordsBox";
            this.Rover1StartCoordsBox.Size = new System.Drawing.Size(100, 20);
            this.Rover1StartCoordsBox.TabIndex = 2;
            this.Rover1StartCoordsBox.TextChanged += new System.EventHandler(this.Rover1StartCoordsBox_TextChanged);
            // 
            // Rover1PathBox
            // 
            this.Rover1PathBox.Location = new System.Drawing.Point(60, 168);
            this.Rover1PathBox.Name = "Rover1PathBox";
            this.Rover1PathBox.Size = new System.Drawing.Size(100, 20);
            this.Rover1PathBox.TabIndex = 3;
            this.Rover1PathBox.TextChanged += new System.EventHandler(this.Rover1PathBox_TextChanged);
            // 
            // Rover2StartCoordsBox
            // 
            this.Rover2StartCoordsBox.Location = new System.Drawing.Point(60, 271);
            this.Rover2StartCoordsBox.Name = "Rover2StartCoordsBox";
            this.Rover2StartCoordsBox.Size = new System.Drawing.Size(100, 20);
            this.Rover2StartCoordsBox.TabIndex = 4;
            this.Rover2StartCoordsBox.TextChanged += new System.EventHandler(this.Rover2StartCoordsBox_TextChanged);
            // 
            // Rover2PathBox
            // 
            this.Rover2PathBox.Location = new System.Drawing.Point(60, 320);
            this.Rover2PathBox.Name = "Rover2PathBox";
            this.Rover2PathBox.Size = new System.Drawing.Size(100, 20);
            this.Rover2PathBox.TabIndex = 5;
            this.Rover2PathBox.TextChanged += new System.EventHandler(this.Rover2PathBox_TextChanged);
            // 
            // Rover1OutputBox
            // 
            this.Rover1OutputBox.Location = new System.Drawing.Point(428, 122);
            this.Rover1OutputBox.Name = "Rover1OutputBox";
            this.Rover1OutputBox.Size = new System.Drawing.Size(100, 20);
            this.Rover1OutputBox.TabIndex = 6;
            this.Rover1OutputBox.TextChanged += new System.EventHandler(this.Rover1OutputBox_TextChanged);
            // 
            // Rover2OutputBox
            // 
            this.Rover2OutputBox.Location = new System.Drawing.Point(428, 271);
            this.Rover2OutputBox.Name = "Rover2OutputBox";
            this.Rover2OutputBox.Size = new System.Drawing.Size(100, 20);
            this.Rover2OutputBox.TabIndex = 7;
            this.Rover2OutputBox.TextChanged += new System.EventHandler(this.Rover2OutputBox_TextChanged);
            // 
            // ErrorLogBox
            // 
            this.ErrorLogBox.Location = new System.Drawing.Point(264, 320);
            this.ErrorLogBox.Name = "ErrorLogBox";
            this.ErrorLogBox.Size = new System.Drawing.Size(264, 20);
            this.ErrorLogBox.TabIndex = 8;
            this.ErrorLogBox.TextChanged += new System.EventHandler(this.ErrorLogBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorLogBox);
            this.Controls.Add(this.Rover2OutputBox);
            this.Controls.Add(this.Rover1OutputBox);
            this.Controls.Add(this.Rover2PathBox);
            this.Controls.Add(this.Rover2StartCoordsBox);
            this.Controls.Add(this.Rover1PathBox);
            this.Controls.Add(this.Rover1StartCoordsBox);
            this.Controls.Add(this.PlateauSize);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Gordon S for Sherwin Williams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PlateauSize;
        private System.Windows.Forms.TextBox Rover1StartCoordsBox;
        private System.Windows.Forms.TextBox Rover1PathBox;
        private System.Windows.Forms.TextBox Rover2StartCoordsBox;
        private System.Windows.Forms.TextBox Rover2PathBox;
        private System.Windows.Forms.TextBox Rover1OutputBox;
        private System.Windows.Forms.TextBox Rover2OutputBox;
        private System.Windows.Forms.TextBox ErrorLogBox;
    }
}

