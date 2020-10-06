using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {

            // Returns to GameScreen if user wants to play again

            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {

            // Closes program if quit button is selected

            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

            // Switches to StartScreen if user wants to return to the menu

            Form f = this.FindForm();
            f.Controls.Remove(this);
            StartScreen ss = new StartScreen();
            f.Controls.Add(ss);
            ss.Focus();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {

            // Displays user's score in the previous game

            finalScoreLabel.Text = "Score : " + GameScreen.playerScore;
        }
    }
}
