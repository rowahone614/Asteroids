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
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }
    }
}
