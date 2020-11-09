using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Asteroids
{
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            countLabel.Text = 3 + "";
            Thread.Sleep(1000);
            Refresh();
            countLabel.Text = 2 + "";
            Thread.Sleep(1000);
            Refresh();
            countLabel.Text = 1 + "";
            Thread.Sleep(1000);

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);

            gs.Focus();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            OptionsScreen os = new OptionsScreen();
            f.Controls.Add(os);
            os.Focus();
        }

        private void startButton_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Turquoise;
            optionsButton.BackColor = Color.LightGray;
        }

        private void optionsButton_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.LightGray;
            optionsButton.BackColor = Color.Turquoise;
        }
    }
}
