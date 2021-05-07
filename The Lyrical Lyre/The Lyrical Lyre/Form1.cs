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



        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Left = (this.ClientRectangle.Width / 2) - (btnStart.Width / 2);
            btnStart.Top = (this.ClientRectangle.Height / 2) - (btnStart.Height / 2);
        }
    }
}
