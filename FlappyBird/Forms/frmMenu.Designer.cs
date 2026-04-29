namespace FlappyBird
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
            this.picBackground.Location = new System.Drawing.Point(-7, -34);
            this.picBackground.Margin = new System.Windows.Forms.Padding(2);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1024, 655);
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(284, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(467, 64);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "FLAPPY BIRD EXTENDED";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseWaitCursor = true;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial Narrow", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(312, 128);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(116, 26);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Player Name";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(452, 126);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerName.MaxLength = 20;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(188, 28);
            this.txtPlayerName.TabIndex = 3;
            // 
            // lblHighScore
            // 
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblHighScore.Location = new System.Drawing.Point(379, 166);
            this.lblHighScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(207, 26);
            this.lblHighScore.TabIndex = 4;
            this.lblHighScore.Text = "Điểm cao nhất: 0";
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnForest
            // 
            this.btnForest.BackColor = System.Drawing.Color.Green;
            this.btnForest.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForest.ForeColor = System.Drawing.Color.White;
            this.btnForest.Location = new System.Drawing.Point(145, 256);
            this.btnForest.Margin = new System.Windows.Forms.Padding(2);
            this.btnForest.Name = "btnForest";
            this.btnForest.Size = new System.Drawing.Size(160, 51);
            this.btnForest.TabIndex = 5;
            this.btnForest.Text = "🌳 Forest";
            this.btnForest.UseVisualStyleBackColor = false;
            this.btnForest.Click += new System.EventHandler(this.btnForest_Click);
            // 
            // btnVolcano
            // 
            this.btnVolcano.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVolcano.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolcano.Location = new System.Drawing.Point(332, 256);
            this.btnVolcano.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolcano.Name = "btnVolcano";
            this.btnVolcano.Size = new System.Drawing.Size(160, 51);
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
            this.btnStorm.Location = new System.Drawing.Point(523, 256);
            this.btnStorm.Margin = new System.Windows.Forms.Padding(2);
            this.btnStorm.Name = "btnStorm";
            this.btnStorm.Size = new System.Drawing.Size(160, 51);
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
            this.btnSpace.Location = new System.Drawing.Point(721, 256);
            this.btnSpace.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(160, 51);
            this.btnSpace.TabIndex = 8;
            this.btnSpace.Text = "🌌 Space";
            this.btnSpace.UseVisualStyleBackColor = false;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click_1);
            // 
            // btnLeaderBoard
            // 
            this.btnLeaderBoard.BackColor = System.Drawing.Color.Gold;
            this.btnLeaderBoard.Font = new System.Drawing.Font("Arial Narrow", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderBoard.ForeColor = System.Drawing.Color.Black;
            this.btnLeaderBoard.Location = new System.Drawing.Point(395, 410);
            this.btnLeaderBoard.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeaderBoard.Name = "btnLeaderBoard";
            this.btnLeaderBoard.Size = new System.Drawing.Size(233, 38);
            this.btnLeaderBoard.TabIndex = 9;
            this.btnLeaderBoard.Text = "🏆 Bảng xếp hạng";
            this.btnLeaderBoard.UseVisualStyleBackColor = false;
            this.btnLeaderBoard.Click += new System.EventHandler(this.btnLeaderBoard_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(412, 346);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 45);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "▶ START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 610);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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