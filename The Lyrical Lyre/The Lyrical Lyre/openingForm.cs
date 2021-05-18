using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace The_Lyrical_Lyre
{
    public partial class FormMain : Form
    {
        // REFER TO SEMESTER 1 FINAL PROJECT AND MUSIC MAKER PROJECT FOR STUFF BELOW:

        // Global Variables
        FormSelect open; // Creates variable to for form
        SoundPlayer opening; // Opening music for title screen

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set button to center of form
            btnStart.Left = (this.ClientRectangle.Width / 2) - (btnStart.Width / 2);
            btnStart.Top = (this.ClientRectangle.Height - (this.ClientRectangle.Height / 4)) - (btnStart.Height / 2);

            // Play Music

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Open new Form for level selection
            open = new FormSelect();
            open.Show();
        }
    }
}
