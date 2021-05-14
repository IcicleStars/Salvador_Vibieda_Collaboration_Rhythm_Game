using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyrical_Lyre
{
    public partial class keziahsAttempt : Form
    {
        // Create Public Variables
        List<PictureBox> tileButtons = new List<PictureBox>();
        int speed;

        public keziahsAttempt()
        {
            InitializeComponent();
        }

        private void keziahsAttempt_Load(object sender, EventArgs e)
        {
            // Assign Variables
            speed = 10;

            // Set Road List
            tileButtons.Add(redClick);
            tileButtons.Add(blueClick);

            // Start Timer
            tileMover.Start();

        }

        private void tileMover_Tick(object sender, EventArgs e)
        {
            // Move each tile
            for (int i = 0; i < tileButtons.Count; i++)
            {
                PictureBox eachClick = tileButtons[i];
                eachClick.Top += speed;

                if (eachClick.Top >= this.ClientRectangle.Height)
                {
                    eachClick.Top = -eachClick.Height; // ?? I don't know how this works.
                }
            }

        }
    }
}
