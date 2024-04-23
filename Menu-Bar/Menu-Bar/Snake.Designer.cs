namespace Menu_Bar
{
    partial class Snake
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
            this.startButton = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.CurrScore = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.Land = new System.Windows.Forms.PictureBox();
            this.SnakeTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Land)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(611, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(115, 58);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // snapButton
            // 
            this.snapButton.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snapButton.Location = new System.Drawing.Point(611, 89);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(115, 58);
            this.snapButton.TabIndex = 2;
            this.snapButton.Text = "Snap";
            this.snapButton.UseVisualStyleBackColor = true;
            this.snapButton.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // CurrScore
            // 
            this.CurrScore.AutoSize = true;
            this.CurrScore.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrScore.Location = new System.Drawing.Point(598, 194);
            this.CurrScore.Name = "CurrScore";
            this.CurrScore.Size = new System.Drawing.Size(106, 33);
            this.CurrScore.TabIndex = 3;
            this.CurrScore.Text = "Score: 0";
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highScore.Location = new System.Drawing.Point(598, 260);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(127, 33);
            this.highScore.TabIndex = 4;
            this.highScore.Text = "Highest: 0";
            // 
            // Land
            // 
            this.Land.BackColor = System.Drawing.Color.ForestGreen;
            this.Land.Location = new System.Drawing.Point(12, 12);
            this.Land.Name = "Land";
            this.Land.Size = new System.Drawing.Size(580, 680);
            this.Land.TabIndex = 1;
            this.Land.TabStop = false;
            this.Land.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePBox);
            // 
            // SnakeTime
            // 
            this.SnakeTime.Interval = 55;
            this.SnakeTime.Tick += new System.EventHandler(this.TimeEvent);
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 711);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.CurrScore);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.Land);
            this.Controls.Add(this.startButton);
            this.MaximumSize = new System.Drawing.Size(997, 992);
            this.MinimumSize = new System.Drawing.Size(764, 758);
            this.Name = "Snake";
            this.ShowIcon = false;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Land)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox Land;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.Label CurrScore;
        private System.Windows.Forms.Label highScore;
        private System.Windows.Forms.Timer SnakeTime;
    }
}