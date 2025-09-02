namespace DigitalWatchApp
{
    partial class DigitalWatch
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
            this.components = new System.ComponentModel.Container();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblHMSeparator = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblMSSeparator = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.tmrSeparator = new System.Windows.Forms.Timer(this.components);
            this.tmrWatch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(23, 60);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(124, 73);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "HH";
            // 
            // lblHMSeparator
            // 
            this.lblHMSeparator.AutoSize = true;
            this.lblHMSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMSeparator.Location = new System.Drawing.Point(153, 60);
            this.lblHMSeparator.Name = "lblHMSeparator";
            this.lblHMSeparator.Size = new System.Drawing.Size(50, 73);
            this.lblHMSeparator.TabIndex = 1;
            this.lblHMSeparator.Text = ":";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(209, 60);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(138, 73);
            this.lblMinute.TabIndex = 2;
            this.lblMinute.Text = "mm";
            // 
            // lblMSSeparator
            // 
            this.lblMSSeparator.AutoSize = true;
            this.lblMSSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSeparator.Location = new System.Drawing.Point(353, 60);
            this.lblMSSeparator.Name = "lblMSSeparator";
            this.lblMSSeparator.Size = new System.Drawing.Size(50, 73);
            this.lblMSSeparator.TabIndex = 3;
            this.lblMSSeparator.Text = ":";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(409, 60);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(96, 73);
            this.lblSecond.TabIndex = 4;
            this.lblSecond.Text = "ss";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(511, 60);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(68, 73);
            this.lblPeriod.TabIndex = 5;
            this.lblPeriod.Text = "tt";
            // 
            // tmrSeparator
            // 
            this.tmrSeparator.Enabled = true;
            this.tmrSeparator.Interval = 500;
            this.tmrSeparator.Tick += new System.EventHandler(this.tmrSeparator_Tick);
            // 
            // tmrWatch
            // 
            this.tmrWatch.Enabled = true;
            this.tmrWatch.Interval = 1000;
            this.tmrWatch.Tick += new System.EventHandler(this.tmrWatch_Tick);
            // 
            // DigitalWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 163);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblMSSeparator);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHMSeparator);
            this.Controls.Add(this.lblHour);
            this.Name = "DigitalWatch";
            this.Text = "DigitalWatch";
            this.Load += new System.EventHandler(this.DigitalWatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblHMSeparator;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblMSSeparator;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Timer tmrSeparator;
        private System.Windows.Forms.Timer tmrWatch;
    }
}