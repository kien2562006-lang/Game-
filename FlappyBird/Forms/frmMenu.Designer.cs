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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnLeaderBoard = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnStorm = new System.Windows.Forms.Button();
            this.btnVolcano = new System.Windows.Forms.Button();
            this.btnForest = new System.Windows.Forms.Button();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial Narrow", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerName.Location = new System.Drawing.Point(20, 219);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(116, 26);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.Click += new System.EventHandler(this.lblPlayerName_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(151, 219);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerName.MaxLength = 20;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(188, 28);
            this.txtPlayerName.TabIndex = 3;
            // 
            // btnLeaderBoard
            // 
            this.btnLeaderBoard.BackColor = System.Drawing.Color.Gold;
            this.btnLeaderBoard.Font = new System.Drawing.Font("Arial Black", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderBoard.ForeColor = System.Drawing.Color.Black;
            this.btnLeaderBoard.Location = new System.Drawing.Point(108, 401);
            this.btnLeaderBoard.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeaderBoard.Name = "btnLeaderBoard";
            this.btnLeaderBoard.Size = new System.Drawing.Size(274, 38);
            this.btnLeaderBoard.TabIndex = 9;
            this.btnLeaderBoard.Text = "🏆 Leader Board";
            this.btnLeaderBoard.UseVisualStyleBackColor = false;
            this.btnLeaderBoard.Click += new System.EventHandler(this.btnLeaderBoard_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(145, 303);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 45);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "▶ START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.BackColor = System.Drawing.Color.Transparent;
            this.btnSpace.BackgroundImage = global::FlappyBird.Properties.Resources.Space;
            this.btnSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpace.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.ForeColor = System.Drawing.Color.White;
            this.btnSpace.Location = new System.Drawing.Point(772, 414);
            this.btnSpace.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(187, 139);
            this.btnSpace.TabIndex = 8;
            this.btnSpace.Text = "🌌 Space";
            this.btnSpace.UseVisualStyleBackColor = false;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click_1);
            // 
            // btnStorm
            // 
            this.btnStorm.BackColor = System.Drawing.Color.Transparent;
            this.btnStorm.BackgroundImage = global::FlappyBird.Properties.Resources.Storm;
            this.btnStorm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStorm.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorm.ForeColor = System.Drawing.Color.White;
            this.btnStorm.Location = new System.Drawing.Point(772, 238);
            this.btnStorm.Margin = new System.Windows.Forms.Padding(2);
            this.btnStorm.Name = "btnStorm";
            this.btnStorm.Size = new System.Drawing.Size(187, 139);
            this.btnStorm.TabIndex = 7;
            this.btnStorm.Text = "⛈ Storm";
            this.btnStorm.UseVisualStyleBackColor = false;
            this.btnStorm.Click += new System.EventHandler(this.btnStorm_Click);
            // 
            // btnVolcano
            // 
            this.btnVolcano.BackColor = System.Drawing.Color.Transparent;
            this.btnVolcano.BackgroundImage = global::FlappyBird.Properties.Resources.Volcano;
            this.btnVolcano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolcano.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolcano.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolcano.Location = new System.Drawing.Point(491, 238);
            this.btnVolcano.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolcano.Name = "btnVolcano";
            this.btnVolcano.Size = new System.Drawing.Size(187, 139);
            this.btnVolcano.TabIndex = 6;
            this.btnVolcano.Text = "🌋 Volcano";
            this.btnVolcano.UseVisualStyleBackColor = false;
            this.btnVolcano.Click += new System.EventHandler(this.btnVolcano_Click);
            // 
            // btnForest
            // 
            this.btnForest.BackColor = System.Drawing.Color.Transparent;
            this.btnForest.BackgroundImage = global::FlappyBird.Properties.Resources.Forest;
            this.btnForest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForest.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForest.ForeColor = System.Drawing.Color.White;
            this.btnForest.Location = new System.Drawing.Point(491, 414);
            this.btnForest.Margin = new System.Windows.Forms.Padding(2);
            this.btnForest.Name = "btnForest";
            this.btnForest.Size = new System.Drawing.Size(187, 139);
            this.btnForest.TabIndex = 5;
            this.btnForest.Text = "🌳 Forest";
            this.btnForest.UseVisualStyleBackColor = false;
            this.btnForest.Click += new System.EventHandler(this.btnForest_Click);
            // 
            // picBird
            // 
            this.picBird.BackColor = System.Drawing.Color.Transparent;
            this.picBird.BackgroundImage = global::FlappyBird.Properties.Resources.bird_gif;
            this.picBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBird.Location = new System.Drawing.Point(685, 52);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(100, 102);
            this.picBird.TabIndex = 12;
            this.picBird.TabStop = false;
            this.picBird.Click += new System.EventHandler(this.picBird_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FlappyBird.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(75, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnExit.Location = new System.Drawing.Point(183, 469);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 39);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.phong_nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 610);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBird);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLeaderBoard);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnStorm);
            this.Controls.Add(this.btnVolcano);
            this.Controls.Add(this.btnForest);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Extended";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnForest;
        private System.Windows.Forms.Button btnVolcano;
        private System.Windows.Forms.Button btnStorm;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button btnLeaderBoard;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}