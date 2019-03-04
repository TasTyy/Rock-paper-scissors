using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Help;

namespace Igra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Game game = new Game();

        public int Player1State;
        public int Player2State;
        public int Result;

        private void igrajButton_Click(object sender, EventArgs e)
        {
            Result = game.Play();
            Player1State = game.player1State;
            Player2State = game.player2State;

            // Player 1 state (slika)
            if (Player1State == 0)
            {
                pictureBox1.Image = Igra.Properties.Resources.Papir;
            }
            else if (Player1State == 1)
            {
                pictureBox1.Image = Igra.Properties.Resources.Kamen;
            }
            else if (Player1State == 2)
            {
                pictureBox1.Image = Igra.Properties.Resources.Škarje;
            }

            // Player 2 state (slika)
            if (Player2State == 0)
            {
                pictureBox2.Image = Igra.Properties.Resources.Papir;
            }
            else if (Player2State == 1)
            {
                pictureBox2.Image = Igra.Properties.Resources.Kamen;
            }
            else if (Player2State == 2)
            {
                pictureBox2.Image = Igra.Properties.Resources.Škarje;
            }

            // Rezultat
            if (Result == 1)
            {
                game.player1Score++;
                ScoreLabel1.Text = "Igralec 1 score: " + game.player1Score.ToString();

                if (game.player1Score > Game.player1HighScore)
                {
                    HighScoreLabel1.Text = "Igralec 1 HighScore: " + game.player1Score.ToString();
                }
            }

            if (Result == 2)
            {
                game.player2Score++;
                ScoreLabel2.Text = "Igralec 2 score: " + game.player2Score.ToString();

                if (game.player2Score > Game.player2HighScore)
                {
                    HighScoreLabel2.Text = "Igralec 2 HighScore: " + game.player2Score.ToString();
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Game.player1HighScore = game.player1Score;
            Game.player1HighScore = game.player2Score;

            ScoreLabel1.Text = "Igralec 1 score: " + 0.ToString();
            ScoreLabel2.Text = "Igralec 2 score: " + 0.ToString();

            game.player1Score = 0;
            game.player2Score = 0;

            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }
    }
}
