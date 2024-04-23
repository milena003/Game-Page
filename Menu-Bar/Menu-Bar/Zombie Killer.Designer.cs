namespace Menu_Bar
{
    partial class Zombie_Killer
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
            this.ammos = new System.Windows.Forms.Label();
            this.killScore = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.Label();
            this.healthProg = new System.Windows.Forms.ProgressBar();
            this.ZombieTimer = new System.Windows.Forms.Timer(this.components);
            this.Killer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Killer)).BeginInit();
            this.SuspendLayout();
            // 
            // ammos
            // 
            this.ammos.AutoSize = true;
            this.ammos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammos.ForeColor = System.Drawing.Color.White;
            this.ammos.Location = new System.Drawing.Point(8, 12);
            this.ammos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ammos.Name = "ammos";
            this.ammos.Size = new System.Drawing.Size(177, 29);
            this.ammos.TabIndex = 0;
            this.ammos.Text = "Ammunition: 0";
            // 
            // killScore
            // 
            this.killScore.AutoSize = true;
            this.killScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killScore.ForeColor = System.Drawing.Color.White;
            this.killScore.Location = new System.Drawing.Point(313, 12);
            this.killScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.killScore.Name = "killScore";
            this.killScore.Size = new System.Drawing.Size(92, 29);
            this.killScore.TabIndex = 1;
            this.killScore.Text = "Kills: 0";
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health.ForeColor = System.Drawing.Color.White;
            this.health.Location = new System.Drawing.Point(545, 12);
            this.health.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(95, 29);
            this.health.TabIndex = 2;
            this.health.Text = "Health:";
            // 
            // healthProg
            // 
            this.healthProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.healthProg.Location = new System.Drawing.Point(644, 12);
            this.healthProg.Margin = new System.Windows.Forms.Padding(2);
            this.healthProg.Name = "healthProg";
            this.healthProg.Size = new System.Drawing.Size(243, 27);
            this.healthProg.TabIndex = 3;
            this.healthProg.Value = 100;
            // 
            // ZombieTimer
            // 
            this.ZombieTimer.Enabled = true;
            this.ZombieTimer.Interval = 20;
            this.ZombieTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Killer
            // 
            this.Killer.Image = global::Menu_Bar.Properties.Resources.up;
            this.Killer.Location = new System.Drawing.Point(395, 533);
            this.Killer.Margin = new System.Windows.Forms.Padding(2);
            this.Killer.Name = "Killer";
            this.Killer.Size = new System.Drawing.Size(71, 100);
            this.Killer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Killer.TabIndex = 4;
            this.Killer.TabStop = false;
            // 
            // Zombie_Killer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(908, 648);
            this.Controls.Add(this.Killer);
            this.Controls.Add(this.healthProg);
            this.Controls.Add(this.health);
            this.Controls.Add(this.killScore);
            this.Controls.Add(this.ammos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1006, 977);
            this.MinimumSize = new System.Drawing.Size(926, 695);
            this.Name = "Zombie_Killer";
            this.ShowIcon = false;
            this.Text = "Zombie_Killer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Killer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ammos;
        private System.Windows.Forms.Label killScore;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.ProgressBar healthProg;
        private System.Windows.Forms.PictureBox Killer;
        private System.Windows.Forms.Timer ZombieTimer;
    }
}