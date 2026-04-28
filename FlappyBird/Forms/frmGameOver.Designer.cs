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
            this.SuspendLayout();
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(37, 114);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(75, 23);
            this.btnRetry.TabIndex = 0;
            this.btnRetry.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(265, 137);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "button2";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Location = new System.Drawing.Point(178, 258);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(44, 16);
            this.lblFinalScore.TabIndex = 2;
            this.lblFinalScore.Text = "label1";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(510, 257);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(44, 16);
            this.lblHighScore.TabIndex = 3;
            this.lblHighScore.Text = "label2";
            // 
            // lblNewRecord
            // 
            this.lblNewRecord.AutoSize = true;
            this.lblNewRecord.Location = new System.Drawing.Point(609, 363);
            this.lblNewRecord.Name = "lblNewRecord";
            this.lblNewRecord.Size = new System.Drawing.Size(44, 16);
            this.lblNewRecord.TabIndex = 4;
            this.lblNewRecord.Text = "label3";
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNewRecord);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnRetry);
            this.Name = "frmGameOver";
            this.Text = "frmGameOver";
            this.Load += new System.EventHandler(this.frmGameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblNewRecord;
    }
}