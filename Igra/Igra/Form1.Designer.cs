namespace Igra
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.igrajButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.HighScoreLabel1 = new System.Windows.Forms.Label();
            this.ScoreLabel1 = new System.Windows.Forms.Label();
            this.HighScoreLabel2 = new System.Windows.Forms.Label();
            this.ScoreLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(265, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 261);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // igrajButton
            // 
            this.igrajButton.Location = new System.Drawing.Point(12, 347);
            this.igrajButton.Name = "igrajButton";
            this.igrajButton.Size = new System.Drawing.Size(456, 23);
            this.igrajButton.TabIndex = 2;
            this.igrajButton.Text = "Igraj";
            this.igrajButton.UseVisualStyleBackColor = true;
            this.igrajButton.Click += new System.EventHandler(this.igrajButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 376);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(456, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // HighScoreLabel1
            // 
            this.HighScoreLabel1.AutoSize = true;
            this.HighScoreLabel1.Location = new System.Drawing.Point(9, 9);
            this.HighScoreLabel1.Name = "HighScoreLabel1";
            this.HighScoreLabel1.Size = new System.Drawing.Size(104, 13);
            this.HighScoreLabel1.TabIndex = 4;
            this.HighScoreLabel1.Text = "Igralec 1 HighScore:";
            // 
            // ScoreLabel1
            // 
            this.ScoreLabel1.AutoSize = true;
            this.ScoreLabel1.Location = new System.Drawing.Point(9, 42);
            this.ScoreLabel1.Name = "ScoreLabel1";
            this.ScoreLabel1.Size = new System.Drawing.Size(80, 13);
            this.ScoreLabel1.TabIndex = 5;
            this.ScoreLabel1.Text = "Igralec 1 score:";
            // 
            // HighScoreLabel2
            // 
            this.HighScoreLabel2.AutoSize = true;
            this.HighScoreLabel2.Location = new System.Drawing.Point(262, 9);
            this.HighScoreLabel2.Name = "HighScoreLabel2";
            this.HighScoreLabel2.Size = new System.Drawing.Size(104, 13);
            this.HighScoreLabel2.TabIndex = 6;
            this.HighScoreLabel2.Text = "Igralec 2 HighScore:";
            // 
            // ScoreLabel2
            // 
            this.ScoreLabel2.AutoSize = true;
            this.ScoreLabel2.Location = new System.Drawing.Point(262, 42);
            this.ScoreLabel2.Name = "ScoreLabel2";
            this.ScoreLabel2.Size = new System.Drawing.Size(80, 13);
            this.ScoreLabel2.TabIndex = 7;
            this.ScoreLabel2.Text = "Igralec 2 score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 413);
            this.Controls.Add(this.ScoreLabel2);
            this.Controls.Add(this.HighScoreLabel2);
            this.Controls.Add(this.ScoreLabel1);
            this.Controls.Add(this.HighScoreLabel1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.igrajButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Igra";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button igrajButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label HighScoreLabel1;
        private System.Windows.Forms.Label ScoreLabel1;
        private System.Windows.Forms.Label HighScoreLabel2;
        private System.Windows.Forms.Label ScoreLabel2;
    }
}

