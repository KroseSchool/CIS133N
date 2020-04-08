namespace kevinRoseCalculatorForm
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
            this.processButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.firstNumLabel = new System.Windows.Forms.Label();
            this.secondNumLabel = new System.Windows.Forms.Label();
            this.calcPictureBox = new System.Windows.Forms.PictureBox();
            this.calcOutLabel = new System.Windows.Forms.Label();
            this.calcResultsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.moduloButton = new System.Windows.Forms.Button();
            this.exponentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calcPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(234, 52);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "&Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(76, 52);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(152, 19);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(100, 20);
            this.num1TextBox.TabIndex = 2;
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(152, 65);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(100, 20);
            this.num2TextBox.TabIndex = 3;
            // 
            // firstNumLabel
            // 
            this.firstNumLabel.AutoSize = true;
            this.firstNumLabel.Location = new System.Drawing.Point(6, 34);
            this.firstNumLabel.Name = "firstNumLabel";
            this.firstNumLabel.Size = new System.Drawing.Size(66, 13);
            this.firstNumLabel.TabIndex = 4;
            this.firstNumLabel.Text = "First Number";
            // 
            // secondNumLabel
            // 
            this.secondNumLabel.AutoSize = true;
            this.secondNumLabel.Location = new System.Drawing.Point(6, 68);
            this.secondNumLabel.Name = "secondNumLabel";
            this.secondNumLabel.Size = new System.Drawing.Size(84, 13);
            this.secondNumLabel.TabIndex = 5;
            this.secondNumLabel.Text = "Second Number";
            // 
            // calcPictureBox
            // 
            this.calcPictureBox.Location = new System.Drawing.Point(66, 12);
            this.calcPictureBox.Name = "calcPictureBox";
            this.calcPictureBox.Size = new System.Drawing.Size(100, 50);
            this.calcPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calcPictureBox.TabIndex = 6;
            this.calcPictureBox.TabStop = false;
            // 
            // calcOutLabel
            // 
            this.calcOutLabel.AutoSize = true;
            this.calcOutLabel.Location = new System.Drawing.Point(167, 45);
            this.calcOutLabel.Name = "calcOutLabel";
            this.calcOutLabel.Size = new System.Drawing.Size(50, 13);
            this.calcOutLabel.TabIndex = 7;
            this.calcOutLabel.Text = "Result is:";
            this.calcOutLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // calcResultsLabel
            // 
            this.calcResultsLabel.AutoSize = true;
            this.calcResultsLabel.Location = new System.Drawing.Point(223, 45);
            this.calcResultsLabel.Name = "calcResultsLabel";
            this.calcResultsLabel.Size = new System.Drawing.Size(53, 13);
            this.calcResultsLabel.TabIndex = 8;
            this.calcResultsLabel.Text = "resultText";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.processButton);
            this.groupBox1.Location = new System.Drawing.Point(66, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 103);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secondNumLabel);
            this.groupBox2.Controls.Add(this.firstNumLabel);
            this.groupBox2.Controls.Add(this.num1TextBox);
            this.groupBox2.Controls.Add(this.num2TextBox);
            this.groupBox2.Location = new System.Drawing.Point(66, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.exponentButton);
            this.groupBox3.Controls.Add(this.moduloButton);
            this.groupBox3.Controls.Add(this.divisionButton);
            this.groupBox3.Controls.Add(this.multButton);
            this.groupBox3.Controls.Add(this.minusButton);
            this.groupBox3.Controls.Add(this.plusButton);
            this.groupBox3.Controls.Add(this.calcOutLabel);
            this.groupBox3.Controls.Add(this.calcResultsLabel);
            this.groupBox3.Location = new System.Drawing.Point(439, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 305);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(18, 27);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(45, 45);
            this.plusButton.TabIndex = 9;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(18, 71);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(45, 45);
            this.minusButton.TabIndex = 10;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            // 
            // multButton
            // 
            this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multButton.Location = new System.Drawing.Point(18, 113);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(45, 45);
            this.multButton.TabIndex = 11;
            this.multButton.Text = "*";
            this.multButton.UseVisualStyleBackColor = true;
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(18, 155);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(45, 45);
            this.divisionButton.TabIndex = 12;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            // 
            // moduloButton
            // 
            this.moduloButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduloButton.Location = new System.Drawing.Point(18, 197);
            this.moduloButton.Name = "moduloButton";
            this.moduloButton.Size = new System.Drawing.Size(45, 45);
            this.moduloButton.TabIndex = 13;
            this.moduloButton.Text = "%";
            this.moduloButton.UseVisualStyleBackColor = true;
            // 
            // exponentButton
            // 
            this.exponentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exponentButton.Location = new System.Drawing.Point(18, 239);
            this.exponentButton.Name = "exponentButton";
            this.exponentButton.Size = new System.Drawing.Size(45, 45);
            this.exponentButton.TabIndex = 14;
            this.exponentButton.Text = "^";
            this.exponentButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcPictureBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calcPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox num2TextBox;
        private System.Windows.Forms.Label firstNumLabel;
        private System.Windows.Forms.Label secondNumLabel;
        private System.Windows.Forms.PictureBox calcPictureBox;
        private System.Windows.Forms.Label calcOutLabel;
        private System.Windows.Forms.Label calcResultsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button exponentButton;
        private System.Windows.Forms.Button moduloButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Label label1;
    }
}

