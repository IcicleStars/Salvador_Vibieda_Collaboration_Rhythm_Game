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
    public partial class Test_Form : Form
    {

        public Test_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SoundPlayer sndplayr = new

            SoundPlayer(Properties.Resources.randomAudio);

            sndplayr.Play();

        }
    }
}
