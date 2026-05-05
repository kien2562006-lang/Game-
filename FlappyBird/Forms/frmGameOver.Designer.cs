namespace FlappyBird.Forms
{
    partial class frmGameOver
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
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblNewRecord = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRetry.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.Location = new System.Drawing.Point(36, 254);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(125, 66);
            this.btnRetry.TabIndex = 0;
            this.btnRetry.Text = "⭮ RETRY";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMenu.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(428, 254);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(125, 66);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "🏠 MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.BackColor = System.Drawing.Color.Black;
            this.lblFinalScore.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFinalScore.Location = new System.Drawing.Point(237, 169);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(108, 24);
            this.lblFinalScore.TabIndex = 2;
            this.lblFinalScore.Text = "SCORE:    ";
            this.lblFinalScore.Click += new System.EventHandler(this.lblFinalScore_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Black;
            this.lblHighScore.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.White;
            this.lblHighScore.Location = new System.Drawing.Point(208, 210);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(166, 24);
            this.lblHighScore.TabIndex = 3;
            this.lblHighScore.Text = "BEST SCORE:    ";
            this.lblHighScore.Click += new System.EventHandler(this.lblHighScore_Click);
            // 
            // lblNewRecord
            // 
            this.lblNewRecord.AutoSize = true;
            this.lblNewRecord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewRecord.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRecord.ForeColor = System.Drawing.Color.Yellow;
            this.lblNewRecord.Location = new System.Drawing.Point(200, 254);
            this.lblNewRecord.Name = "lblNewRecord";
            this.lblNewRecord.Size = new System.Drawing.Size(182, 24);
            this.lblNewRecord.TabIndex = 4;
            this.lblNewRecord.Text = "🎉 NEW RECORD!";
            this.lblNewRecord.Click += new System.EventHandler(this.lblNewRecord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FlappyBird.Properties.Resources.game_over1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(55, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 160);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.phong_nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNewRecord);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnRetry);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGameOver";
            this.Load += new System.EventHandler(this.frmGameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblNewRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}