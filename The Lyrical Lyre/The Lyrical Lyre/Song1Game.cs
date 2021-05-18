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
        Random generate = new Random();
        List<PictureBox> notes = new List<PictureBox>();
        PictureBox selectedNote, randomNote;
        int tempo = 5, max;
        // bool W, A, S, D, I, J, K, L;

        private void Song1Game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                if (picWBox.Top == picBorder.Top - picWBox.Top || picWBox.Top == picBorder.Top - picWBox.Top + 1 || picWBox.Top == picBorder.Top - picWBox.Top + 2 || picWBox.Top == picBorder.Top - picWBox.Top + 3)
                {
                    perfect();
                }
                else if (picWBox.Top > picBorder.Top - picWBox.Top && picWBox.Top < picBorder.Bottom)
                {
                    great();
                }
                else if (picWBox.Top > picBorder.Bottom || picWBox.Top < picBorder.Top - picWBox.Top)
                {
                    failure();
                }
            }
        }

        private void tempoTimer_Tick(object sender, EventArgs e)
        {
            // Create variables
            randomNote = notes[generate.Next(max)];
            callNote(randomNote);
            picBorder.BackColor = Color.Black;
        }

        private void picWBox_Click(object sender, EventArgs e)
        {
            callNote(picWBox);
        }

        public Song1Game()
        {
            InitializeComponent();
        }

        private void Song1Game_Load(object sender, EventArgs e)
        {
            // Populate pictureBox list 
            notes.Add(picWBox);
            notes.Add(picABox);
            notes.Add(picSBox);
            notes.Add(picDBox);
            notes.Add(picIBox);
            notes.Add(picJBox);
            notes.Add(picKBox);
            notes.Add(picLBox);



            // Set Defaults
            setDefaults();
            picABox.Visible = true;

            this.KeyPreview = true;
            tempoTimer.Start();

        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            //tick++;

            selectedNote.Top += tempo;

            if (selectedNote.Top >= picBorder.Top)
            {
                animationTimer.Stop();
                resetNote(selectedNote);
                setDefaults();
            }
            

        }

        // METHODS BELOW HERE
        // this method calls a note down
        private void callNote(PictureBox Note)
        {
            selectedNote = Note;
            selectedNote.Visible = true;
            animationTimer.Start();
        }

        // Set Default
        private void setDefaults()
        { 
            max = notes.Count;
            for (var index = 0; index < max; index++)
            {
               notes[index].Top = 0;
               notes[index].Visible = false;
               
            }


        }

        // Reset Picturebox
        private void resetNote(PictureBox note)
        {
            note.Visible = false;
            note.Top = 0;
        }

        // Perfect Score
        private void perfect()
        {
            resetNote(selectedNote);
            animationTimer.Stop();
            picBorder.BackColor = Color.Blue;
        }

        // Great!
        private void great()
        {
            resetNote(selectedNote);
            animationTimer.Stop();
            picBorder.BackColor = Color.Yellow;
        }

        // Failure
        private void failure()
        {
            resetNote(selectedNote);
            animationTimer.Stop();
            picBorder.BackColor = Color.Red;
        }
    }
}
