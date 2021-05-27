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
        
        // Create Global Variables
        Random generate = new Random();
        List<PictureBox> notes = new List<PictureBox>();
        List<Label> keyNotes = new List<Label>();
        PictureBox selectedNote, randomNote;
        int tempo = 5, max, score, tick;
        SoundPlayer sound = new SoundPlayer(Properties.Resources.guizhongsLullaby);


        private void Song1Game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (lbStart.Visible == true)
                {
                    lbStart.Visible = false;
                    tempoTimer.Start();
                    sound.Play();
                    timer.Start();
                }



            }

            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
                sound.Stop();


            }
            if (e.KeyCode == Keys.W)
            {
                if (picWBox.Top >= (picBorder.Top - picWBox.Top) - 5 && picWBox.Top <= (picBorder.Top - picWBox.Top) + 5)
                {
                    perfect();
                }
                else if (picWBox.Top > (picBorder.Top - picWBox.Top) + 5 && picWBox.Top < picBorder.Bottom)
                {
                    great();                
                }
                else if (picWBox.Top > picBorder.Bottom || picWBox.Top < picBorder.Top - picWBox.Top - 5)
                {
                    failure();
                }
            }

            if(e.KeyCode == Keys.A)
            {
                if (picABox.Top >= (picBorder.Top - picABox.Top) - 5 && picABox.Top <= (picBorder.Top - picABox.Top) + 5)
                {
                    perfect();
                }
                else if (picABox.Top > (picBorder.Top - picABox.Top) + 5 && picABox.Top < picBorder.Bottom)
                {
                    great();
                }
                else if (picABox.Top > picBorder.Bottom || picABox.Top < picBorder.Top - picABox.Top)
                {
                    failure();
                }
            }
            
            if (e.KeyCode == Keys.S)
            {
                if (picSBox.Top >= (picBorder.Top - picSBox.Top) - 5 && picSBox.Top <= (picBorder.Top - picSBox.Top) + 5)
                {
                    perfect();
                }
                else if (picSBox.Top > (picBorder.Top - picSBox.Top) + 5 && picSBox.Top < picBorder.Bottom)
                {
                    great();
                }
                else if (picSBox.Top > picBorder.Bottom || picSBox.Top < picBorder.Top - picSBox.Top)
                {
                    failure();
                }
            }

            if (e.KeyCode == Keys.D)
            {
                if (picDBox.Top >= (picBorder.Top - picDBox.Top) - 5 && picDBox.Top <= (picBorder.Top - picDBox.Top) + 5)
                {
                    perfect();
                }
                else if (picDBox.Top > (picBorder.Top - picDBox.Top) + 5 && picDBox.Top < picBorder.Bottom)
                {
                    great();
                }
                else if (picDBox.Top > picBorder.Bottom || picDBox.Top < picBorder.Top - picDBox.Top)
                {
                    failure();
                }
            }

            if (e.KeyCode == Keys.I)
            {
                if (picIBox.Top >= (picBorder.Top - picIBox.Top) - 5 && picIBox.Top <= (picBorder.Top - picIBox.Top) + 5)
                {
                    perfect();
                }
                else if (picIBox.Top > (picBorder.Top - picIBox.Top) + 5 && picIBox.Top < picBorder.Bottom)
                {
                    great();
                }
                else if (picIBox.Top > picBorder.Bottom || picIBox.Top < picBorder.Top - picIBox.Top)
                {
                    failure();
                }
            }

            if (e.KeyCode == Keys.J)
            {
                if (picJBox.Top >= (picBorder.Top - picJBox.Height) - 5 && picJBox.Top <= (picBorder.Top - picJBox.Height) + 5)
                {
                    perfect();
                }
                else if (picJBox.Top > (picBorder.Top - picJBox.Top) + 5 && picJBox.Top < picBorder.Bottom)
                {
                    great();
                }
                else if (picJBox.Top > picBorder.Bottom || picJBox.Top < picBorder.Top - picJBox.Top)
                {
                    failure();
                }
            }

            if (e.KeyCode == Keys.K)
            {
                if (picKBox.Top >= (picBorder.Top - picKBox.Top) - 5 && picKBox.Top <= (picBorder.Top - picKBox.Top) + 5)
                {
                    perfect();
                }
                else if (picKBox.Top > (picBorder.Top - picKBox.Top) + 5 && picKBox.Top < picBorder.Bottom)
                {
                    great();
                }
                else if (picKBox.Top > picBorder.Bottom || picKBox.Top < picBorder.Top - picKBox.Top)
                {
                    failure();
                }
            }

            if (e.KeyCode == Keys.L)
            {
                if (picLBox.Top >= (picBorder.Top - picLBox.Top) - 5 && picLBox.Top <= (picBorder.Top - picLBox.Top) + 5)
                {
                    perfect();
                }
                else if (picLBox.Top > (picBorder.Top - picLBox.Top) + 5 && picLBox.Top < picBorder.Bottom)
                {
                    great();
                }
                else if (picLBox.Top > picBorder.Bottom || picLBox.Top < picBorder.Top - picLBox.Top)
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
            /*picBorder.BackColor = Color.Black;
            for (var i = 0; i < keyNotes.Count; i++)
            {
                keyNotes[i].BackColor = Color.Black;
            }*/
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

            // Populate Label List
            keyNotes.Add(lbW);
            keyNotes.Add(lbA);
            keyNotes.Add(lbS);
            keyNotes.Add(lbD);
            keyNotes.Add(lbI);
            keyNotes.Add(lbJ);
            keyNotes.Add(lbK);
            keyNotes.Add(lbL);

            // Set Defaults
            score = 0;
            setDefaults();

            this.KeyPreview = true;

            // Play Music
            // Play Music

            // dawn winery
            // adeptus retirement
            // the wind and the star traveler


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
                failure();
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
          /*  for (var i = 0; i < keyNotes.Count; i++)
            {
                keyNotes[i].BackColor = Color.Black;
            }*/
            lbScore.Text = score.ToString();


        }

        // Reset Picturebox
        private void resetNote(PictureBox note)
        {
            note.Visible = false;
            note.Top = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tick++; 

            if (tick == 30)
            {
                setDefaults();
                lbStart.Visible = true;
                timer.Stop();
                animationTimer.Stop();
                tempoTimer.Stop();
                sound.Stop();
                
            }
        }

        // Perfect Score
        private void perfect()
        {
            resetNote(selectedNote);
            animationTimer.Stop();
         /*   picBorder.BackColor = Color.Blue;
            for (var i = 0; i < keyNotes.Count; i++)
            {
                keyNotes[i].BackColor = Color.Blue;
            }*/
            score += 100;
            lbScore.Text = score.ToString();
            picStatusScore.Image = Properties.Resources.perfectVenti;
            picParonPerfectStatus.Image = Properties.Resources.perfect;
            picParonPerfectStatus.Visible = true;
            picOkStatus.Visible = false;
        }

        // Great!
        private void great()
        {
            resetNote(selectedNote);
            animationTimer.Stop();
            /*picBorder.BackColor = Color.Yellow;
            for (var i = 0; i < keyNotes.Count; i++)
            {
                keyNotes[i].BackColor = Color.Yellow;
            }*/
            score += 25;
            lbScore.Text = score.ToString();
            picStatusScore.Image = Properties.Resources.okVenti;
            picParonPerfectStatus.Visible = false;
            picOkStatus.Visible = true;
        }

        // Failure
        private void failure()
        {
            resetNote(selectedNote);
            animationTimer.Stop();
            /*picBorder.BackColor = Color.Red;
            for (var i = 0; i < keyNotes.Count; i++)
            {
                keyNotes[i].BackColor = Color.Red;
            }*/
            score -= 10;
            lbScore.Text = score.ToString();
            picStatusScore.Image = Properties.Resources.pardonVenti;
            picParonPerfectStatus.Visible = true;
            picParonPerfectStatus.Image = Properties.Resources.Pardon;
            picOkStatus.Visible = false;
        }
    }
}
