using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Lyrical_Lyre
{
    public partial class Song1Game : Form
    {

        // Create Global Variables 
        List<PictureBox> noteList = new List<PictureBox>();
        PictureBox selected;
        int tick = 0;
        public Song1Game()
        {
            InitializeComponent();
        }
        private void Song1Game_Load(object sender, EventArgs e)
        {
            // Allow keyboard 
            this.KeyPreview = true;

            // Populate List
            noteList.Add(picWBox);
            noteList.Add(picABox);
            noteList.Add(picSBox);
            noteList.Add(picDBox);
            noteList.Add(picIBox);
            noteList.Add(picJBox);
            noteList.Add(picKBox);
            noteList.Add(picLBox);

            // Do stuff with pictureboxes 
            for (var index = 0; index < noteList.Count; index++)
            {
                noteList[index].Top = 0; 


            }


        }
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            tick += 1;
            selected.Top += 10; 

            if (tick == 36)
            {
                animationTimer.Stop();
                tick = 0;
                selected.Visible = false;
            }

        }

        // METHODS BELOW HERE

        // This Method calls for the animation timer. 
        private void animateItem(PictureBox note)
        {
            selected = note;
            animationTimer.Start();
        }

        private void picWBox_Click(object sender, EventArgs e)
        {
            animateItem(picWBox);
        }

        private void picKBox_Click(object sender, EventArgs e)
        {

        }
    }
}
