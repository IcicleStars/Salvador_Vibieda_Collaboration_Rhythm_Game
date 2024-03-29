﻿using System;
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

    // REMEMBER TO CHANGE THE NAME OF "Song1", "Song2" etc. TO THE ACTUAL SONG!!!

    public partial class FormSelect : Form
    {

        // Create Global Variables
        bool song1 = false, song2 = false, song3 = false, song4 = false, difficultyIn, selected = false;
        int tick = 0, tick2 = 0;
        public bool easy, medium, hard;
        int level;
        SoundPlayer sound = new SoundPlayer(Properties.Resources.adeptusRetirement);

        // Global Variables to OPEN game
        Song1Game open;
        Song2Game open2;
        SongGame3 open3;
        Song4Game open4;

        private void btnSong1_Click(object sender, EventArgs e)
        {            
            sound.Stop();
            sound = new SoundPlayer(Properties.Resources.guizhongsLullaby);

            song1 = true;
            song2 = false;
            song3 = false;
            song4 = false;
            animateDifficultyIn();
            animateSongsOut();


            sound.Play();
         
        }

        private void btnSong2_Click(object sender, EventArgs e)
        {            
            sound.Stop();
            sound = new SoundPlayer(Properties.Resources.dawnWinery);


            sound.Play();

            song1 = false;
            song2 = true;
            song3 = false;
            song4 = false;
            animateDifficultyIn();
            animateSongsOut();
        }

        private void btnSong3_Click(object sender, EventArgs e)
        {

            sound.Stop();
            sound = new SoundPlayer(Properties.Resources.adeptusRetirement);


            sound.Play();

            song1 = false;
            song2 = false;
            song3 = true;
            song4 = false;
            animateDifficultyIn();
            animateSongsOut();
        }

        private void btnSong4_Click(object sender, EventArgs e)
        {
            sound.Stop();
            sound = new SoundPlayer(Properties.Resources.theWindAndTheStarTraveler);


            sound.Play();
            song1 = false;
            song2 = false;
            song3 = false;
            song4 = true;
            animateDifficultyIn();
            animateSongsOut();
        }

        private void timerAnimateDifficulty_Tick(object sender, EventArgs e)
        {
            if (selected == false)
            {
                tick += 1;
                lbDifficulty.Left = lbDifficulty.Left + 10;
                btnEasy.Left += 10;
                btnMedium.Left += 10;
                btnHard.Left += 10;

                if (tick == 20)
                {
                    timerAnimateDifficulty.Stop();
                    tick = 0;
                }
            }

        }

        private void timerDetectBool_Tick(object sender, EventArgs e)
        {
            if (song1)
            {
                btnSong1.Click -= btnSong1_Click;
            }
            else if (song2)
            {
                btnSong2.Click -= btnSong2_Click;
            }
            else if (song3)
            {
                btnSong3.Click -= btnSong3_Click;
            }
            else if (song4)
            {
                btnSong4.Click -= btnSong4_Click;
            }
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            sound.Stop();
            level = 3;

            if (song1)
            {
                open = new Song1Game(level);
                open.Show();

            }
            if (song2)
            {
                open2 = new Song2Game(level);
                open2.Show();
            }
            if (song3)
            {
                open3 = new SongGame3(level);
                open3.Show();
            }
            if (song4)
            {
                open4 = new Song4Game(level);
                open4.Show();
            }
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            sound.Stop();
            level = 1;

            if (song1)
            {
                open = new Song1Game(level);
                open.Show();
            
            }
            if (song2)
            {
                open2 = new Song2Game(level);
                open2.Show();
            }
            if (song3)
            {
                open3 = new SongGame3(level);
                open3.Show();
            }
            if (song4)
            {
                open4 = new Song4Game(level);
                open4.Show();
            }

        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            sound.Stop();
            level = 2;

            if (song1)
            {
                open = new Song1Game(level);
                open.Show();

            }
            if (song2)
            {
                open2 = new Song2Game(level);
                open2.Show();
            }
            if (song3)
            {
                open3 = new SongGame3(level);
                open3.Show();
            }
            if (song4)
            {
                open4 = new Song4Game(level);
                open4.Show();
            }
        }

        SoundPlayer Music; // Plays selected song

        // REAL TIMER NAME: TimerAnimateSong (animates songs)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (selected == false) // Animates Song CHoices when one is selected
            {
                tick2 += 1;
                lbSong.Left += 6;

                if (song1)
                {
                    btnSong2.Left += 10;
                    btnSong3.Left += 10;
                    btnSong4.Left += 10;
                }
                else if (song2)
                {
                    btnSong1.Left += 10;
                    btnSong3.Left += 10;
                    btnSong4.Left += 10;
                }
                else if (song3)
                {
                    btnSong2.Left += 10;
                    btnSong1.Left += 10;
                    btnSong4.Left += 10;
                }
                else if (song4)
                {
                    btnSong2.Left += 10;
                    btnSong3.Left += 10;
                    btnSong1.Left += 10;
                }


                if (tick2 == 20)
                {
                    timerAnimateSong.Stop();
                    tick2 = 0;
                    selected = true;
                    btnSong1.Click += btnSong1_Click;
                    btnSong2.Click += btnSong2_Click;
                    btnSong3.Click += btnSong3_Click;
                    btnSong4.Click += btnSong4_Click;
                }
            }
            else if (selected)  // Animates the song choices once one has already been selected
            {
                tick2 += 1;

                if (song1)
                {
                    btnSong1.Left -= 10;

                    if (btnSong4.Left != 659)
                    {
                        btnSong4.Left += 10;
                    }
                    else if (btnSong2.Left != 659)
                    {
                        btnSong2.Left += 10;
                    }
                    else if (btnSong3.Left != 659)
                    {
                        btnSong3.Left += 10;
                    }
                }
                else if (song2)
                {
                    btnSong2.Left -= 10;

                    if (btnSong1.Left != 659)
                    {
                        btnSong1.Left += 10;
                    }
                    else if (btnSong4.Left != 659)
                    {
                        btnSong4.Left += 10;
                    }
                    else if (btnSong3.Left != 659)
                    {
                        btnSong3.Left += 10;
                    }
                }
                else if (song3)
                {
                    btnSong3.Left -= 10;

                    if (btnSong1.Left != 659)
                    {
                        btnSong1.Left += 10;
                    }
                    else if (btnSong2.Left != 659)
                    {
                        btnSong2.Left += 10;
                    }
                    else if (btnSong4.Left != 659)
                    {
                        btnSong4.Left += 10;
                    }
                }
                else if (song4)
                {
                    btnSong4.Left -= 10;

                    if (btnSong1.Left != 659)
                    {
                        btnSong1.Left += 10;
                    }
                    else if (btnSong2.Left != 659)
                    {
                        btnSong2.Left += 10;
                    }
                    else if (btnSong3.Left != 659)
                    {
                        btnSong3.Left += 10;
                    }
                }

                // Stop and Reset Timer
                if (tick2 == 20)
                {
                    timerAnimateSong.Stop();
                    tick2 = 0;

                    // Reenables the clicking of buttons
                    btnSong1.Click += btnSong1_Click;
                    btnSong2.Click += btnSong2_Click;
                    btnSong3.Click += btnSong3_Click;
                    btnSong4.Click += btnSong4_Click;
                }

            }

        }

        public FormSelect()
        {
            InitializeComponent();
        }

        private void FormSelect_Load(object sender, EventArgs e)
        {
            // Hide Difficulties
            lbDifficulty.Visible = false;
            btnEasy.Visible = false;
            btnMedium.Visible = false;
            btnHard.Visible = false;

            // Start Detection Timer
            timerDetectBool.Start();
            sound.Play();
        }

        // METHODS BELOW HERE

        // Method animates the difficulty title and buttons.
        private void animateDifficultyIn()
        {
            lbDifficulty.Visible = true;
            btnEasy.Visible = true;
            btnMedium.Visible = true;
            btnHard.Visible = true;
            difficultyIn = true;
            timerAnimateDifficulty.Start();
        }

        // Method animates the song choice buttons
        private void animateSongsOut()
        {
            btnSong1.Click -= btnSong1_Click;
            btnSong2.Click -= btnSong2_Click;
            btnSong3.Click -= btnSong3_Click;
            btnSong4.Click -= btnSong4_Click;
            timerAnimateSong.Start();
        }
    }
}
