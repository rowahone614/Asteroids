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
            
            // Counts down from three

            countLabel.Text = 3 + "";
            Refresh();
            Thread.Sleep(1000);
            countLabel.Text = 2 + "";
            Refresh();
            Thread.Sleep(1000);
            countLabel.Text = 1 + "";
            Refresh();
            Thread.Sleep(1000);

            // Closes the menu and changes to GameScreen

            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {

            // Closes the menu and changes to OptionsScreen

            Form f = this.FindForm();
            f.Controls.Remove(this);
            OptionsScreen os = new OptionsScreen();
            f.Controls.Add(os);
            os.Focus();
        }
    }
}
