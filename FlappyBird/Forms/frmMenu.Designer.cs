namespace FlappyBird.Forms
{
    partial class frmMenu
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
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.btnForest = new System.Windows.Forms.Button();
            this.btnVolcano = new System.Windows.Forms.Button();
            this.btnStorm = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnLeaderBoard = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Location = new System.Drawing.Point(-13, -42);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1536, 1024);
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            this.picBackground.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(418, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 100);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "FLAPPY BIRD EXTENDED";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseWaitCursor = true;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial Narrow", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(468, 200);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(184, 42);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Player Name";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(678, 197);
            this.txtPlayerName.MaxLength = 20;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(280, 41);
            this.txtPlayerName.TabIndex = 3;
            // 
            // lblHighScore
            // 
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblHighScore.Location = new System.Drawing.Point(568, 260);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(311, 40);
            this.lblHighScore.TabIndex = 4;
            this.lblHighScore.Text = "Điểm cao nhất: 0";
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnForest
            // 
            this.btnForest.BackColor = System.Drawing.Color.Green;
            this.btnForest.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForest.ForeColor = System.Drawing.Color.White;
            this.btnForest.Location = new System.Drawing.Point(217, 400);
            this.btnForest.Name = "btnForest";
            this.btnForest.Size = new System.Drawing.Size(240, 80);
            this.btnForest.TabIndex = 5;
            this.btnForest.Text = "🌳 Forest";
            this.btnForest.UseVisualStyleBackColor = false;
            this.btnForest.Click += new System.EventHandler(this.btnForest_Click);
            // 
            // btnVolcano
            // 
            this.btnVolcano.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVolcano.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolcano.Location = new System.Drawing.Point(498, 400);
            this.btnVolcano.Name = "btnVolcano";
            this.btnVolcano.Size = new System.Drawing.Size(240, 80);
            this.btnVolcano.TabIndex = 6;
            this.btnVolcano.Text = "🌋 Volcano";
            this.btnVolcano.UseVisualStyleBackColor = false;
            this.btnVolcano.Click += new System.EventHandler(this.btnVolcano_Click);
            // 
            // btnStorm
            // 
            this.btnStorm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStorm.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorm.ForeColor = System.Drawing.Color.White;
            this.btnStorm.Location = new System.Drawing.Point(784, 400);
            this.btnStorm.Name = "btnStorm";
            this.btnStorm.Size = new System.Drawing.Size(240, 80);
            this.btnStorm.TabIndex = 7;
            this.btnStorm.Text = "⛈ Storm";
            this.btnStorm.UseVisualStyleBackColor = false;
            this.btnStorm.Click += new System.EventHandler(this.btnStorm_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSpace.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.ForeColor = System.Drawing.Color.White;
            this.btnSpace.Location = new System.Drawing.Point(1082, 400);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(240, 80);
            this.btnSpace.TabIndex = 8;
            this.btnSpace.Text = "🌌 Space";
            this.btnSpace.UseVisualStyleBackColor = false;
            // 
            // btnLeaderBoard
            // 
            this.btnLeaderBoard.BackColor = System.Drawing.Color.Gold;
            this.btnLeaderBoard.Font = new System.Drawing.Font("Arial Narrow", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderBoard.ForeColor = System.Drawing.Color.Black;
            this.btnLeaderBoard.Location = new System.Drawing.Point(593, 640);
            this.btnLeaderBoard.Name = "btnLeaderBoard";
            this.btnLeaderBoard.Size = new System.Drawing.Size(350, 60);
            this.btnLeaderBoard.TabIndex = 9;
            this.btnLeaderBoard.Text = "🏆 Bảng xếp hạng";
            this.btnLeaderBoard.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(618, 540);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(300, 70);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "▶ START";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 953);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLeaderBoard);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnStorm);
            this.Controls.Add(this.btnVolcano);
            this.Controls.Add(this.btnForest);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Extended";
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Button btnForest;
        private System.Windows.Forms.Button btnVolcano;
        private System.Windows.Forms.Button btnStorm;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button btnLeaderBoard;
        private System.Windows.Forms.Button btnStart;
    }
}