namespace Menu_Bar
{
    partial class Gravity_Run
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
            this.Runner = new System.Windows.Forms.PictureBox();
            this.groundTop = new System.Windows.Forms.PictureBox();
            this.groundButtom = new System.Windows.Forms.PictureBox();
            this.BoxUp = new System.Windows.Forms.PictureBox();
            this.BoxDown = new System.Windows.Forms.PictureBox();
            this.RunScore = new System.Windows.Forms.Label();
            this.HScore = new System.Windows.Forms.Label();
            this.RunTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Runner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Runner
            // 
            this.Runner.BackColor = System.Drawing.Color.Transparent;
            this.Runner.Image = global::Menu_Bar.Properties.Resources.run_down0;
            this.Runner.Location = new System.Drawing.Point(196, 221);
            this.Runner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Runner.Name = "Runner";
            this.Runner.Size = new System.Drawing.Size(53, 56);
            this.Runner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Runner.TabIndex = 0;
            this.Runner.TabStop = false;
            // 
            // groundTop
            // 
            this.groundTop.BackgroundImage = global::Menu_Bar.Properties.Resources.platform_tilesblue;
            this.groundTop.Image = global::Menu_Bar.Properties.Resources.platform_tilesblue;
            this.groundTop.Location = new System.Drawing.Point(-7, -4);
            this.groundTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groundTop.Name = "groundTop";
            this.groundTop.Size = new System.Drawing.Size(1323, 50);
            this.groundTop.TabIndex = 1;
            this.groundTop.TabStop = false;
            // 
            // groundButtom
            // 
            this.groundButtom.BackgroundImage = global::Menu_Bar.Properties.Resources.platform_tilesblue;
            this.groundButtom.Image = global::Menu_Bar.Properties.Resources.platform_tilesblue;
            this.groundButtom.Location = new System.Drawing.Point(-15, 508);
            this.groundButtom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groundButtom.Name = "groundButtom";
            this.groundButtom.Size = new System.Drawing.Size(1323, 50);
            this.groundButtom.TabIndex = 2;
            this.groundButtom.TabStop = false;
            // 
            // BoxUp
            // 
            this.BoxUp.BackColor = System.Drawing.Color.Transparent;
            this.BoxUp.Image = global::Menu_Bar.Properties.Resources.box;
            this.BoxUp.Location = new System.Drawing.Point(329, 36);
            this.BoxUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxUp.Name = "BoxUp";
            this.BoxUp.Size = new System.Drawing.Size(41, 81);
            this.BoxUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxUp.TabIndex = 3;
            this.BoxUp.TabStop = false;
            this.BoxUp.Tag = "obstacle";
            // 
            // BoxDown
            // 
            this.BoxDown.BackColor = System.Drawing.Color.Transparent;
            this.BoxDown.Image = global::Menu_Bar.Properties.Resources.box;
            this.BoxDown.Location = new System.Drawing.Point(673, 431);
            this.BoxDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxDown.Name = "BoxDown";
            this.BoxDown.Size = new System.Drawing.Size(41, 81);
            this.BoxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxDown.TabIndex = 4;
            this.BoxDown.TabStop = false;
            this.BoxDown.Tag = "obstacle";
            // 
            // RunScore
            // 
            this.RunScore.AutoSize = true;
            this.RunScore.BackColor = System.Drawing.Color.Transparent;
            this.RunScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunScore.Location = new System.Drawing.Point(8, 6);
            this.RunScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RunScore.Name = "RunScore";
            this.RunScore.Size = new System.Drawing.Size(123, 31);
            this.RunScore.TabIndex = 5;
            this.RunScore.Text = "Score: 0";
            // 
            // HScore
            // 
            this.HScore.AutoSize = true;
            this.HScore.BackColor = System.Drawing.Color.Transparent;
            this.HScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HScore.Location = new System.Drawing.Point(8, 511);
            this.HScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HScore.Name = "HScore";
            this.HScore.Size = new System.Drawing.Size(227, 31);
            this.HScore.TabIndex = 6;
            this.HScore.Text = "Highest score: 0";
            // 
            // RunTime
            // 
            this.RunTime.Enabled = true;
            this.RunTime.Interval = 20;
            this.RunTime.Tick += new System.EventHandler(this.RunTimeEvent);
            // 
            // Gravity_Run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu_Bar.Properties.Resources.background_still;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 550);
            this.Controls.Add(this.HScore);
            this.Controls.Add(this.RunScore);
            this.Controls.Add(this.groundButtom);
            this.Controls.Add(this.groundTop);
            this.Controls.Add(this.BoxUp);
            this.Controls.Add(this.BoxDown);
            this.Controls.Add(this.Runner);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Gravity_Run";
            this.ShowIcon = false;
            this.Text = "Gravity_Run";
            this.Load += new System.EventHandler(this.Gravity_Run_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Runner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Runner;
        private System.Windows.Forms.PictureBox groundTop;
        private System.Windows.Forms.PictureBox groundButtom;
        private System.Windows.Forms.PictureBox BoxUp;
        private System.Windows.Forms.PictureBox BoxDown;
        private System.Windows.Forms.Label RunScore;
        private System.Windows.Forms.Label HScore;
        private System.Windows.Forms.Timer RunTime;
    }
}