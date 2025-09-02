namespace InternetConnectionApp
{
    partial class InternetConnectionApp
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
            this.pcrConnection = new System.Windows.Forms.PictureBox();
            this.tmrConnection = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcrConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // pcrConnection
            // 
            this.pcrConnection.Image = global::InternetConnectionApp.Properties.Resources.red_cross;
            this.pcrConnection.Location = new System.Drawing.Point(23, 63);
            this.pcrConnection.Name = "pcrConnection";
            this.pcrConnection.Size = new System.Drawing.Size(205, 198);
            this.pcrConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrConnection.TabIndex = 0;
            this.pcrConnection.TabStop = false;
            // 
            // tmrConnection
            // 
            this.tmrConnection.Enabled = true;
            this.tmrConnection.Interval = 1000;
            this.tmrConnection.Tick += new System.EventHandler(this.tmrConnection_Tick);
            // 
            // InternetConnectionApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 284);
            this.Controls.Add(this.pcrConnection);
            this.Name = "InternetConnectionApp";
            this.Text = "InternetConnection";
            this.Load += new System.EventHandler(this.InternetConnectionApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcrConnection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcrConnection;
        private System.Windows.Forms.Timer tmrConnection;
    }
}

