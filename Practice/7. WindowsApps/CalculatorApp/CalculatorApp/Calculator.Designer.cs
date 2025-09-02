namespace CalculatorApp
{
    partial class Calculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnInverse = new MetroFramework.Controls.MetroButton();
            this.btnPercent = new MetroFramework.Controls.MetroButton();
            this.btnDivide = new MetroFramework.Controls.MetroButton();
            this.btnNine = new MetroFramework.Controls.MetroButton();
            this.btnEight = new MetroFramework.Controls.MetroButton();
            this.btnSeven = new MetroFramework.Controls.MetroButton();
            this.btnMultiply = new MetroFramework.Controls.MetroButton();
            this.btnSix = new MetroFramework.Controls.MetroButton();
            this.btnFive = new MetroFramework.Controls.MetroButton();
            this.btnFour = new MetroFramework.Controls.MetroButton();
            this.btnSubstract = new MetroFramework.Controls.MetroButton();
            this.btnThree = new MetroFramework.Controls.MetroButton();
            this.btnTwo = new MetroFramework.Controls.MetroButton();
            this.btnOne = new MetroFramework.Controls.MetroButton();
            this.btnPlus = new MetroFramework.Controls.MetroButton();
            this.btnEqual = new MetroFramework.Controls.MetroButton();
            this.btnZero = new MetroFramework.Controls.MetroButton();
            this.btnDot = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(23, 89);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDisplay.Size = new System.Drawing.Size(222, 64);
            this.txtDisplay.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(12, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Location = new System.Drawing.Point(195, 177);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 30);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(139, 177);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.AutoSize = true;
            this.btnInverse.Location = new System.Drawing.Point(83, 177);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(50, 30);
            this.btnInverse.TabIndex = 7;
            this.btnInverse.Text = "1/x";
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.AutoSize = true;
            this.btnPercent.Location = new System.Drawing.Point(27, 177);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(50, 30);
            this.btnPercent.TabIndex = 6;
            this.btnPercent.Tag = "";
            this.btnPercent.Text = "%";
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.AutoSize = true;
            this.btnDivide.Location = new System.Drawing.Point(195, 213);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 30);
            this.btnDivide.TabIndex = 13;
            this.btnDivide.Text = "/";
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnNine
            // 
            this.btnNine.AutoSize = true;
            this.btnNine.Location = new System.Drawing.Point(139, 213);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(50, 30);
            this.btnNine.TabIndex = 12;
            this.btnNine.Text = "9";
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.AutoSize = true;
            this.btnEight.Location = new System.Drawing.Point(83, 213);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(50, 30);
            this.btnEight.TabIndex = 11;
            this.btnEight.Text = "8";
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.AutoSize = true;
            this.btnSeven.Location = new System.Drawing.Point(27, 213);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(50, 30);
            this.btnSeven.TabIndex = 10;
            this.btnSeven.Text = "7";
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.AutoSize = true;
            this.btnMultiply.Location = new System.Drawing.Point(195, 249);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(50, 30);
            this.btnMultiply.TabIndex = 17;
            this.btnMultiply.Text = "*";
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSix
            // 
            this.btnSix.AutoSize = true;
            this.btnSix.Location = new System.Drawing.Point(139, 249);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(50, 30);
            this.btnSix.TabIndex = 16;
            this.btnSix.Text = "6";
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.AutoSize = true;
            this.btnFive.Location = new System.Drawing.Point(83, 249);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(50, 30);
            this.btnFive.TabIndex = 15;
            this.btnFive.Text = "5";
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.AutoSize = true;
            this.btnFour.Location = new System.Drawing.Point(27, 249);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(50, 30);
            this.btnFour.TabIndex = 14;
            this.btnFour.Text = "4";
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.AutoSize = true;
            this.btnSubstract.Location = new System.Drawing.Point(195, 285);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(50, 30);
            this.btnSubstract.TabIndex = 21;
            this.btnSubstract.Text = "-";
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnThree
            // 
            this.btnThree.AutoSize = true;
            this.btnThree.Location = new System.Drawing.Point(139, 286);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(50, 30);
            this.btnThree.TabIndex = 20;
            this.btnThree.Text = "3";
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.AutoSize = true;
            this.btnTwo.Location = new System.Drawing.Point(83, 285);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(50, 30);
            this.btnTwo.TabIndex = 19;
            this.btnTwo.Text = "2";
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.AutoSize = true;
            this.btnOne.Location = new System.Drawing.Point(27, 285);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(50, 30);
            this.btnOne.TabIndex = 18;
            this.btnOne.Text = "1";
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSize = true;
            this.btnPlus.Location = new System.Drawing.Point(195, 322);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 30);
            this.btnPlus.TabIndex = 25;
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.AutoSize = true;
            this.btnEqual.Location = new System.Drawing.Point(139, 322);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(50, 30);
            this.btnEqual.TabIndex = 24;
            this.btnEqual.Text = "=";
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnZero
            // 
            this.btnZero.AutoSize = true;
            this.btnZero.Location = new System.Drawing.Point(83, 322);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(50, 30);
            this.btnZero.TabIndex = 23;
            this.btnZero.Text = "0";
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDot
            // 
            this.btnDot.AutoSize = true;
            this.btnDot.Location = new System.Drawing.Point(27, 322);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(50, 30);
            this.btnDot.TabIndex = 22;
            this.btnDot.Text = ".";
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 376);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnInverse;
        private MetroFramework.Controls.MetroButton btnPercent;
        private MetroFramework.Controls.MetroButton btnDivide;
        private MetroFramework.Controls.MetroButton btnNine;
        private MetroFramework.Controls.MetroButton btnEight;
        private MetroFramework.Controls.MetroButton btnSeven;
        private MetroFramework.Controls.MetroButton btnMultiply;
        private MetroFramework.Controls.MetroButton btnSix;
        private MetroFramework.Controls.MetroButton btnFive;
        private MetroFramework.Controls.MetroButton btnFour;
        private MetroFramework.Controls.MetroButton btnSubstract;
        private MetroFramework.Controls.MetroButton btnThree;
        private MetroFramework.Controls.MetroButton btnTwo;
        private MetroFramework.Controls.MetroButton btnOne;
        private MetroFramework.Controls.MetroButton btnPlus;
        private MetroFramework.Controls.MetroButton btnEqual;
        private MetroFramework.Controls.MetroButton btnZero;
        private MetroFramework.Controls.MetroButton btnDot;
    }
}