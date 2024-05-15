using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class TicTacToe : Form
    {

        public TicTacToe()
        {
            InitializeComponent();
        }


        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

        private void ResetButton(Guna2ImageButton btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Transparent;
            btn.Tag = "?";
        }

        private void ResetGame()
        {
            ResetButton(imgbtn1);
            ResetButton(imgbtn2);
            ResetButton(imgbtn3); 
            ResetButton(imgbtn4);
            ResetButton(imgbtn5);
            ResetButton(imgbtn6);
            ResetButton(imgbtn7);
            ResetButton(imgbtn8);
            ResetButton(imgbtn9);

            lbTurn.Text = "Player 1";
            lbWinner.Text = "In Progress";
            GameStatus.GameOver = false;
            GameStatus.PlayCount = 0;
            GameStatus.Winner = enWinner.GameInProgress;

        }
        void EndGame()
        {
            lbTurn.Text = "Gmae Over";

            switch(GameStatus.Winner)
            {
                case enWinner.Player1:
                    lbWinner.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    lbWinner.Text = "Player 2";
                    break;

                default:
                    lbWinner.Text = "Draw";
                    break;
            }

            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        public bool CheckValues(Guna2ImageButton btn1, Guna2ImageButton btn2, Guna2ImageButton btn3)
        {

            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString()) 
            {
                btn1.BackColor = Color.YellowGreen;
                btn2.BackColor = Color.YellowGreen;
                btn3.BackColor = Color.YellowGreen;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
              
            }

            GameStatus.GameOver = false;
            return false;

        }
       
        public void CheckWinner()
        {
            if (CheckValues(imgbtn1, imgbtn2, imgbtn3))
                return;

            if (CheckValues(imgbtn4, imgbtn5, imgbtn6))
                return;

            if (CheckValues(imgbtn7, imgbtn8, imgbtn9))
                return;

            if (CheckValues(imgbtn1, imgbtn4, imgbtn7))
               return;

            if (CheckValues(imgbtn2, imgbtn5, imgbtn8))
               return;

            if (CheckValues(imgbtn3, imgbtn6, imgbtn9))
               return;

            if (CheckValues(imgbtn1, imgbtn5, imgbtn9))
                return;

            if (CheckValues(imgbtn3, imgbtn5, imgbtn7))
                return;


        }
        
        public void ChangeImage(Guna2ImageButton btn) 
        {

            if (btn.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lbTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lbTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
  
            }
            else
            {
                MessageBox.Show("Wrong Choice Please Choice Anthor Box", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TicTacToe_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen pen = new Pen(White, 10);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 290, 250, 820, 250);
            e.Graphics.DrawLine(pen, 450, 500, 450, 130);


            e.Graphics.DrawLine(pen, 290, 390, 820, 390);
            e.Graphics.DrawLine(pen, 650, 500, 650, 130);
        }

        private void lbTurn_Click(object sender, EventArgs e)
        {

        }

        private void btnRestartGame_MouseHover(object sender, EventArgs e)
        {

        }

        private void lbTicTacToeHeader_Click(object sender, EventArgs e)
        {

        }

        private void lbGaneOver_Click(object sender, EventArgs e)
        {

        }

        private void lbWinner_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton_Click(object sender, EventArgs e)
        {
            ChangeImage((Guna2ImageButton)sender);
        }   

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void lbWinner_Click_1(object sender, EventArgs e)
        {

        }
    }
}
