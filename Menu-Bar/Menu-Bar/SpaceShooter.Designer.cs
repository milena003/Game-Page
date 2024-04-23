namespace Menu_Bar
{
    partial class SpaceShooter
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
            this.SpaceTime = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.MoveArsenals = new System.Windows.Forms.Timer(this.components);
            this.EnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyArsenal = new System.Windows.Forms.Timer(this.components);
            this.Result = new System.Windows.Forms.Label();
            this.Reply = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.lvlLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceTime
            // 
            this.SpaceTime.Enabled = true;
            this.SpaceTime.Interval = 10;
            this.SpaceTime.Tick += new System.EventHandler(this.SpaceTime_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Menu_Bar.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(296, 391);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // MoveArsenals
            // 
            this.MoveArsenals.Enabled = true;
            this.MoveArsenals.Interval = 20;
            this.MoveArsenals.Tick += new System.EventHandler(this.MoveArsenals_Tick);
            // 
            // EnemyTimer
            // 
            this.EnemyTimer.Enabled = true;
            this.EnemyTimer.Tick += new System.EventHandler(this.EnemyTimer_Tick);
            // 
            // EnemyArsenal
            // 
            this.EnemyArsenal.Enabled = true;
            this.EnemyArsenal.Interval = 20;
            this.EnemyArsenal.Tick += new System.EventHandler(this.EnemyArsenal_Tick);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.AliceBlue;
            this.Result.Location = new System.Drawing.Point(275, 104);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(111, 45);
            this.Result.TabIndex = 1;
            this.Result.Text = "label1";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Result.Visible = false;
            // 
            // Reply
            // 
            this.Reply.BackColor = System.Drawing.Color.Transparent;
            this.Reply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reply.Location = new System.Drawing.Point(174, 206);
            this.Reply.Name = "Reply";
            this.Reply.Size = new System.Drawing.Size(299, 41);
            this.Reply.TabIndex = 2;
            this.Reply.Text = "Reply";
            this.Reply.UseVisualStyleBackColor = false;
            this.Reply.Visible = false;
            this.Reply.Click += new System.EventHandler(this.Reply_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(174, 270);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(299, 41);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Orange;
            this.scoreLabel.Location = new System.Drawing.Point(3, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(81, 23);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score: 0";
            // 
            // lvlLabel
            // 
            this.lvlLabel.AutoSize = true;
            this.lvlLabel.BackColor = System.Drawing.Color.Transparent;
            this.lvlLabel.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlLabel.ForeColor = System.Drawing.Color.Orange;
            this.lvlLabel.Location = new System.Drawing.Point(543, 9);
            this.lvlLabel.Name = "lvlLabel";
            this.lvlLabel.Size = new System.Drawing.Size(77, 23);
            this.lvlLabel.TabIndex = 5;
            this.lvlLabel.Text = "Level: 1";
            // 
            // SpaceShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.lvlLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reply);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Player);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "SpaceShooter";
            this.ShowIcon = false;
            this.Text = "SpaceShooter";
            this.Load += new System.EventHandler(this.SpaceShooter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SpaceTime;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer MoveArsenals;
        private System.Windows.Forms.Timer EnemyTimer;
        private System.Windows.Forms.Timer EnemyArsenal;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Reply;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label lvlLabel;
    }
}