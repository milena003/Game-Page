namespace Menu_Bar
{
    partial class Flappy_Bird
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
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.Scoree = new System.Windows.Forms.Label();
            this.Over = new System.Windows.Forms.Label();
            this.NewScore = new System.Windows.Forms.Label();
            this.Hippo = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeUp = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.Jungle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hippo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jungle)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTime
            // 
            this.GameTime.Interval = 20;
            this.GameTime.Tick += new System.EventHandler(this.GameTime_Tick);
            // 
            // Scoree
            // 
            this.Scoree.AutoSize = true;
            this.Scoree.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Scoree.Location = new System.Drawing.Point(19, 19);
            this.Scoree.Name = "Scoree";
            this.Scoree.Size = new System.Drawing.Size(156, 52);
            this.Scoree.TabIndex = 0;
            this.Scoree.Text = "Score: 0";
            // 
            // Over
            // 
            this.Over.AutoSize = true;
            this.Over.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Over.ForeColor = System.Drawing.Color.Gold;
            this.Over.Location = new System.Drawing.Point(275, 265);
            this.Over.Name = "Over";
            this.Over.Size = new System.Drawing.Size(78, 33);
            this.Over.TabIndex = 1;
            this.Over.Text = "Over";
            this.Over.Visible = false;
            // 
            // NewScore
            // 
            this.NewScore.AutoSize = true;
            this.NewScore.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewScore.ForeColor = System.Drawing.Color.Gold;
            this.NewScore.Location = new System.Drawing.Point(188, 338);
            this.NewScore.Name = "NewScore";
            this.NewScore.Size = new System.Drawing.Size(156, 52);
            this.NewScore.TabIndex = 2;
            this.NewScore.Text = "Score: 0";
            this.NewScore.Visible = false;
            // 
            // Hippo
            // 
            this.Hippo.BackColor = System.Drawing.Color.Transparent;
            this.Hippo.Image = global::Menu_Bar.Properties.Resources.bird;
            this.Hippo.Location = new System.Drawing.Point(53, 241);
            this.Hippo.Name = "Hippo";
            this.Hippo.Size = new System.Drawing.Size(76, 66);
            this.Hippo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hippo.TabIndex = 7;
            this.Hippo.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::Menu_Bar.Properties.Resources.bigground;
            this.Ground.Location = new System.Drawing.Point(-12, 624);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1900, 65);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 8;
            this.Ground.TabStop = false;
            // 
            // PipeUp
            // 
            this.PipeUp.Image = global::Menu_Bar.Properties.Resources.pipe;
            this.PipeUp.Location = new System.Drawing.Point(284, 417);
            this.PipeUp.Name = "PipeUp";
            this.PipeUp.Size = new System.Drawing.Size(110, 247);
            this.PipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeUp.TabIndex = 4;
            this.PipeUp.TabStop = false;
            // 
            // PipeDown
            // 
            this.PipeDown.Image = global::Menu_Bar.Properties.Resources.pipedown;
            this.PipeDown.Location = new System.Drawing.Point(504, -36);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(110, 261);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 3;
            this.PipeDown.TabStop = false;
            // 
            // Jungle
            // 
            this.Jungle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Jungle.Image = global::Menu_Bar.Properties.Resources.jungle;
            this.Jungle.Location = new System.Drawing.Point(0, 0);
            this.Jungle.Name = "Jungle";
            this.Jungle.Size = new System.Drawing.Size(682, 653);
            this.Jungle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jungle.TabIndex = 6;
            this.Jungle.TabStop = false;
            // 
            // Flappy_Bird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.Hippo);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeUp);
            this.Controls.Add(this.PipeDown);
            this.Controls.Add(this.NewScore);
            this.Controls.Add(this.Over);
            this.Controls.Add(this.Scoree);
            this.Controls.Add(this.Jungle);
            this.MaximumSize = new System.Drawing.Size(997, 992);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "Flappy_Bird";
            this.ShowIcon = false;
            this.Text = "Flappy_Bird";
            this.Load += new System.EventHandler(this.Flappy_Bird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Hippo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jungle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.Label Scoree;
        private System.Windows.Forms.Label Over;
        private System.Windows.Forms.Label NewScore;
        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox PipeUp;
        private System.Windows.Forms.PictureBox Jungle;
        private System.Windows.Forms.PictureBox Hippo;
        private System.Windows.Forms.PictureBox Ground;
    }
}