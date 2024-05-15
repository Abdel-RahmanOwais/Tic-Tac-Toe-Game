namespace Tic_Tac_Toe_Game
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.lbTicTacToeHeader = new System.Windows.Forms.Label();
            this.lbTurnMain = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbWinnerMain = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestartGame = new Guna.UI2.WinForms.Guna2Button();
            this.imgbtn1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgbtn2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgbtn3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgbtn6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgbtn9 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgbtn8 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgbtn5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgbtn4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgbtn7 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTicTacToeHeader
            // 
            this.lbTicTacToeHeader.AutoSize = true;
            this.lbTicTacToeHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbTicTacToeHeader.Font = new System.Drawing.Font("Prototype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicTacToeHeader.ForeColor = System.Drawing.Color.White;
            this.lbTicTacToeHeader.Location = new System.Drawing.Point(318, 27);
            this.lbTicTacToeHeader.Name = "lbTicTacToeHeader";
            this.lbTicTacToeHeader.Size = new System.Drawing.Size(441, 57);
            this.lbTicTacToeHeader.TabIndex = 0;
            this.lbTicTacToeHeader.Text = "Tic-Tac-Toe Game ";
            this.lbTicTacToeHeader.Click += new System.EventHandler(this.lbTicTacToeHeader_Click);
            // 
            // lbTurnMain
            // 
            this.lbTurnMain.AutoSize = true;
            this.lbTurnMain.BackColor = System.Drawing.Color.Transparent;
            this.lbTurnMain.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurnMain.ForeColor = System.Drawing.Color.Yellow;
            this.lbTurnMain.Location = new System.Drawing.Point(73, 208);
            this.lbTurnMain.Name = "lbTurnMain";
            this.lbTurnMain.Size = new System.Drawing.Size(98, 42);
            this.lbTurnMain.TabIndex = 1;
            this.lbTurnMain.Text = "Turn";
            this.lbTurnMain.Click += new System.EventHandler(this.lbTurn_Click);
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.BackColor = System.Drawing.Color.Transparent;
            this.lbTurn.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.Ivory;
            this.lbTurn.Location = new System.Drawing.Point(53, 266);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(147, 42);
            this.lbTurn.TabIndex = 2;
            this.lbTurn.Text = "Player 1";
            this.lbTurn.Click += new System.EventHandler(this.lbGaneOver_Click);
            // 
            // lbWinnerMain
            // 
            this.lbWinnerMain.AutoSize = true;
            this.lbWinnerMain.BackColor = System.Drawing.Color.Transparent;
            this.lbWinnerMain.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinnerMain.ForeColor = System.Drawing.Color.Yellow;
            this.lbWinnerMain.Location = new System.Drawing.Point(53, 328);
            this.lbWinnerMain.Name = "lbWinnerMain";
            this.lbWinnerMain.Size = new System.Drawing.Size(138, 42);
            this.lbWinnerMain.TabIndex = 3;
            this.lbWinnerMain.Text = "Winner";
            this.lbWinnerMain.Click += new System.EventHandler(this.lbWinner_Click);
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.BackColor = System.Drawing.Color.Transparent;
            this.lbWinner.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbWinner.Location = new System.Drawing.Point(49, 387);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(195, 42);
            this.lbWinner.TabIndex = 4;
            this.lbWinner.Text = "In Progress";
            this.lbWinner.Click += new System.EventHandler(this.lbWinner_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.profile_pic__2_;
            this.pictureBox1.Location = new System.Drawing.Point(37, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Animated = true;
            this.btnRestartGame.AutoRoundedCorners = true;
            this.btnRestartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartGame.BorderColor = System.Drawing.Color.White;
            this.btnRestartGame.BorderRadius = 21;
            this.btnRestartGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestartGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestartGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestartGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestartGame.FillColor = System.Drawing.Color.Brown;
            this.btnRestartGame.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.IndicateFocus = true;
            this.btnRestartGame.Location = new System.Drawing.Point(37, 457);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.PressedColor = System.Drawing.Color.DimGray;
            this.btnRestartGame.Size = new System.Drawing.Size(188, 44);
            this.btnRestartGame.TabIndex = 24;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseTransparentBackground = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // imgbtn1
            // 
            this.imgbtn1.AnimatedGIF = true;
            this.imgbtn1.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.imgbtn1.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn1.ImageRotate = 0F;
            this.imgbtn1.ImageSize = new System.Drawing.Size(100, 100);
            this.imgbtn1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgbtn1.IndicateFocus = true;
            this.imgbtn1.Location = new System.Drawing.Point(328, 128);
            this.imgbtn1.Name = "imgbtn1";
            this.imgbtn1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn1.Size = new System.Drawing.Size(102, 102);
            this.imgbtn1.TabIndex = 25;
            this.imgbtn1.Tag = "?";
            this.imgbtn1.UseTransparentBackground = true;
            this.imgbtn1.Click += new System.EventHandler(this.guna2ImageButton_Click);
            // 
            // imgbtn2
            // 
            this.imgbtn2.AnimatedGIF = true;
            this.imgbtn2.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.imgbtn2.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn2.ImageRotate = 0F;
            this.imgbtn2.ImageSize = new System.Drawing.Size(100, 100);
            this.imgbtn2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgbtn2.IndicateFocus = true;
            this.imgbtn2.Location = new System.Drawing.Point(500, 128);
            this.imgbtn2.Name = "imgbtn2";
            this.imgbtn2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn2.Size = new System.Drawing.Size(102, 102);
            this.imgbtn2.TabIndex = 26;
            this.imgbtn2.Tag = "?";
            this.imgbtn2.UseTransparentBackground = true;
            this.imgbtn2.Click += new System.EventHandler(this.guna2ImageButton_Click);
            // 
            // imgbtn3
            // 
            this.imgbtn3.AnimatedGIF = true;
            this.imgbtn3.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.imgbtn3.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn3.ImageRotate = 0F;
            this.imgbtn3.ImageSize = new System.Drawing.Size(100, 100);
            this.imgbtn3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgbtn3.IndicateFocus = true;
            this.imgbtn3.Location = new System.Drawing.Point(689, 128);
            this.imgbtn3.Name = "imgbtn3";
            this.imgbtn3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn3.Size = new System.Drawing.Size(102, 102);
            this.imgbtn3.TabIndex = 27;
            this.imgbtn3.Tag = "?";
            this.imgbtn3.UseTransparentBackground = true;
            this.imgbtn3.Click += new System.EventHandler(this.guna2ImageButton_Click);
            // 
            // imgbtn6
            // 
            this.imgbtn6.AnimatedGIF = true;
            this.imgbtn6.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn6.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.imgbtn6.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn6.ImageRotate = 0F;
            this.imgbtn6.ImageSize = new System.Drawing.Size(100, 100);
            this.imgbtn6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgbtn6.IndicateFocus = true;
            this.imgbtn6.Location = new System.Drawing.Point(689, 266);
            this.imgbtn6.Name = "imgbtn6";
            this.imgbtn6.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn6.Size = new System.Drawing.Size(102, 102);
            this.imgbtn6.TabIndex = 28;
            this.imgbtn6.Tag = "?";
            this.imgbtn6.UseTransparentBackground = true;
            this.imgbtn6.Click += new System.EventHandler(this.guna2ImageButton_Click);
            // 
            // imgbtn9
            // 
            this.imgbtn9.AnimatedGIF = true;
            this.imgbtn9.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn9.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn9.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.imgbtn9.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn9.ImageRotate = 0F;
            this.imgbtn9.ImageSize = new System.Drawing.Size(100, 100);
            this.imgbtn9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgbtn9.IndicateFocus = true;
            this.imgbtn9.Location = new System.Drawing.Point(689, 399);
            this.imgbtn9.Name = "imgbtn9";
            this.imgbtn9.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn9.Size = new System.Drawing.Size(102, 102);
            this.imgbtn9.TabIndex = 29;
            this.imgbtn9.Tag = "?";
            this.imgbtn9.UseTransparentBackground = true;
            this.imgbtn9.Click += new System.EventHandler(this.guna2ImageButton_Click);
            // 
            // imgbtn8
            // 
            this.imgbtn8.AnimatedGIF = true;
            this.imgbtn8.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn8.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn8.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.imgbtn8.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn8.ImageRotate = 0F;
            this.imgbtn8.ImageSize = new System.Drawing.Size(100, 100);
            this.imgbtn8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgbtn8.IndicateFocus = true;
            this.imgbtn8.Location = new System.Drawing.Point(500, 399);
            this.imgbtn8.Name = "imgbtn8";
            this.imgbtn8.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn8.Size = new System.Drawing.Size(102, 102);
            this.imgbtn8.TabIndex = 30;
            this.imgbtn8.Tag = "?";
            this.imgbtn8.UseTransparentBackground = true;
            this.imgbtn8.Click += new System.EventHandler(this.guna2ImageButton_Click);
            // 
            // imgbtn5
            // 
            this.imgbtn5.AnimatedGIF = true;
            this.imgbtn5.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn5.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.imgbtn5.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn5.ImageRotate = 0F;
            this.imgbtn5.ImageSize = new System.Drawing.Size(100, 100);
            this.imgbtn5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgbtn5.IndicateFocus = true;
            this.imgbtn5.Location = new System.Drawing.Point(500, 266);
            this.imgbtn5.Name = "imgbtn5";
            this.imgbtn5.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn5.Size = new System.Drawing.Size(102, 102);
            this.imgbtn5.TabIndex = 31;
            this.imgbtn5.Tag = "?";
            this.imgbtn5.UseTransparentBackground = true;
            this.imgbtn5.Click += new System.EventHandler(this.guna2ImageButton_Click);
            // 
            // imgbtn4
            // 
            this.imgbtn4.AnimatedGIF = true;
            this.imgbtn4.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn4.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.imgbtn4.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn4.ImageRotate = 0F;
            this.imgbtn4.ImageSize = new System.Drawing.Size(100, 100);
            this.imgbtn4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgbtn4.IndicateFocus = true;
            this.imgbtn4.Location = new System.Drawing.Point(328, 266);
            this.imgbtn4.Name = "imgbtn4";
            this.imgbtn4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn4.Size = new System.Drawing.Size(102, 102);
            this.imgbtn4.TabIndex = 32;
            this.imgbtn4.Tag = "?";
            this.imgbtn4.UseTransparentBackground = true;
            this.imgbtn4.Click += new System.EventHandler(this.guna2ImageButton_Click);
            // 
            // imgbtn7
            // 
            this.imgbtn7.AnimatedGIF = true;
            this.imgbtn7.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn7.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn7.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.imgbtn7.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn7.ImageRotate = 0F;
            this.imgbtn7.ImageSize = new System.Drawing.Size(100, 100);
            this.imgbtn7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgbtn7.IndicateFocus = true;
            this.imgbtn7.Location = new System.Drawing.Point(328, 399);
            this.imgbtn7.Name = "imgbtn7";
            this.imgbtn7.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn7.Size = new System.Drawing.Size(102, 102);
            this.imgbtn7.TabIndex = 33;
            this.imgbtn7.Tag = "?";
            this.imgbtn7.UseTransparentBackground = true;
            this.imgbtn7.Click += new System.EventHandler(this.guna2ImageButton_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(865, 535);
            this.Controls.Add(this.imgbtn7);
            this.Controls.Add(this.imgbtn4);
            this.Controls.Add(this.imgbtn5);
            this.Controls.Add(this.imgbtn8);
            this.Controls.Add(this.imgbtn9);
            this.Controls.Add(this.imgbtn6);
            this.Controls.Add(this.imgbtn3);
            this.Controls.Add(this.imgbtn2);
            this.Controls.Add(this.imgbtn1);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.lbWinnerMain);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.lbTurnMain);
            this.Controls.Add(this.lbTicTacToeHeader);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe Game";
            this.Click += new System.EventHandler(this.guna2ImageButton_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TicTacToe_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTicTacToeHeader;
        private System.Windows.Forms.Label lbTurnMain;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbWinnerMain;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnRestartGame;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn1;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn2;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn3;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn6;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn9;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn8;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn5;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn4;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn7;
    }
}

