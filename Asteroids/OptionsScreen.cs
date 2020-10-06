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
    public partial class OptionsScreen : UserControl
    {
        public OptionsScreen()
        {
            InitializeComponent();
        }
        public static int setLazerColour, setAsteroidColour, setShipColour, setStartingLevel;
        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            setLazerColour = Convert.ToInt32(lazerColourValue.Value);
            setAsteroidColour = Convert.ToInt32(asteroidColourValue.Value);
            setShipColour = Convert.ToInt32(shipColourValue.Value);
            setStartingLevel = Convert.ToInt32(startLevelValue.Value);

            Form f = this.FindForm();
            f.Controls.Remove(this);
            StartScreen ss = new StartScreen();
            f.Controls.Add(ss);
            ss.Focus();
        }
    }
}
