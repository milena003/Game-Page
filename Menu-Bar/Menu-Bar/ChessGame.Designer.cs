namespace Menu_Bar
{
    partial class ChessGame
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
            this.RestartButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RestartButt
            // 
            this.RestartButt.Location = new System.Drawing.Point(389, 2);
            this.RestartButt.Name = "RestartButt";
            this.RestartButt.Size = new System.Drawing.Size(75, 39);
            this.RestartButt.TabIndex = 0;
            this.RestartButt.Text = "Restart";
            this.RestartButt.UseVisualStyleBackColor = true;
            this.RestartButt.Click += new System.EventHandler(this.RestartButt_Click);
            // 
            // ChessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 393);
            this.Controls.Add(this.RestartButt);
            this.Name = "ChessGame";
            this.Text = "ChessGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RestartButt;
    }
}