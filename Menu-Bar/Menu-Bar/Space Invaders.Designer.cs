namespace Menu_Bar
{
    partial class Space_Invaders
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
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ShootTime = new System.Windows.Forms.Timer(this.components);
            this.Triangle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Triangle)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 520);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(89, 24);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // ShootTime
            // 
            this.ShootTime.Interval = 20;
            this.ShootTime.Tick += new System.EventHandler(this.ShootingEvent);
            // 
            // Triangle
            // 
            this.Triangle.Image = global::Menu_Bar.Properties.Resources.triangle;
            this.Triangle.Location = new System.Drawing.Point(357, 462);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(92, 82);
            this.Triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Triangle.TabIndex = 0;
            this.Triangle.TabStop = false;
            // 
            // Space_Invaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(842, 553);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Triangle);
            this.MaximumSize = new System.Drawing.Size(860, 600);
            this.MinimumSize = new System.Drawing.Size(860, 600);
            this.Name = "Space_Invaders";
            this.ShowIcon = false;
            this.Text = "Space_Invaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Triangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Triangle;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer ShootTime;
    }
}