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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plateau Size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rover 1 Start Coords";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rover 1 Instructions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rover 2 Start Coords";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rover2 Instructions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rover 1 End Coords";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rover 2 End Coords";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Collision Notice";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

