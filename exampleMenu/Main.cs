 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace exampleMenu
{
    public partial class Menu : Form
    {
        private int currentLevel;
        SoundPlayer sndplayr = new SoundPlayer(exampleMenu.Properties.Resources.Ring05);        
        public Menu()
        {
            InitializeComponent();
            StartGamePanel.Visible = false;
            OptionPanel.Visible = false;
            TimeTrialPanel.Visible = false;

            sndplayr.Play();
            sndplayr.PlayLooping();
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGamePanel.Visible = true;    
        }

        private void buttonOption_Click(object sender, EventArgs e)
        {
            OptionPanel.Visible = true;
        } 

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Wong Weng Keong and Nixon Yong. The Greatest Jedi of All!", "Creator of Final Typing XIII!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            StartGamePanel.Visible = false;
        }

        private void buttonTimeTrial_Click(object sender, EventArgs e)
        {
            //sndplayr.Stop();
            //keyboard a = new keyboard();
            //a.Show();
            TimeTrialPanel.Visible = true;
        }

        private void buttonHighScore_Click(object sender, EventArgs e)
        {
            int point_score = 0;
            string[] time_score = File.ReadAllLines("highscore_time.txt");
            using (StreamReader sr = new StreamReader("highscore_point.txt"))
            {
                point_score = Convert.ToInt32(sr.ReadLine());
            }
            MessageBox.Show("Point Game HighScore: " + point_score 
                + "\nTime Game Easy HighScore: " + time_score[0]
                + "\nTime Game Medium HighScore: " + time_score[1]
                + "\nTime Game Hard HighScore: " + time_score[2]
                , "\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBackOption_Click(object sender, EventArgs e)
        {
            OptionPanel.Visible = false;
        }

        private void buttonSoundOff_Click(object sender, EventArgs e)
        {
            sndplayr.Stop();
            buttonSoundOff.Enabled = false;
            buttonSoundOn.Enabled = true;

        }

        private void buttonSoundOn_Click(object sender, EventArgs e)
        {
            sndplayr.Play();
            sndplayr.PlayLooping();
            buttonSoundOn.Enabled = false;
            buttonSoundOff.Enabled = true;
        }

        private void buttonBackTT_Click(object sender, EventArgs e)
        {
            TimeTrialPanel.Visible = false;
        }

        private void EasyTT_Click(object sender, EventArgs e)
        {
            currentLevel = 1;
            sndplayr.Stop();
            keyboard a = new keyboard(currentLevel);
            a.Show();
        }

        private void MediumTT_Click(object sender, EventArgs e)
        {
            currentLevel = 2;
            sndplayr.Stop();
            keyboard a = new keyboard(currentLevel);
            a.Show();
        }

        private void HardTT_Click(object sender, EventArgs e)
        {
            currentLevel = 3;
            sndplayr.Stop();
            keyboard a = new keyboard(currentLevel);
            a.Show();
        }

        private void buttonPoints_Click(object sender, EventArgs e)
        {
            sndplayr.Stop();
            point a = new point();
            a.Show();
        }




    }
}
 