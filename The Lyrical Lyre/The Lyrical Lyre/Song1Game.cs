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
    public partial class Song1Game : Form
    {
        public Song1Game()
        {
            InitializeComponent();
        }

        private void Song1Game_Load(object sender, EventArgs e)
        {
            SoundPlayer sndplayr = new

            SoundPlayer(Properties.Resources.randomAudio);

            sndplayr.Play();
        }
    }
}
