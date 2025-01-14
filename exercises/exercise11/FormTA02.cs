﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace exercise11
{
    public partial class FormTA02 : Form
    {
        public FormTA02()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizer;
        string story = "The baby was lying on her back. A blue bird flew in through the window. The blue bird had blue eyes. It sat on the baby's crib. The bird had a bell around its neck. The bell rang. The baby smiled. The baby reached for the bell. The bird shook its head. The bell fell off the bird's neck. It fell next to the baby. The baby picked up the bell. The baby rang the bell. Another blue bird flew in through the window. This blue bird also had blue eyes. The baby had brown eyes. The birds looked at the baby. The baby looked at the birds. The baby rang the bell again. Both birds flew away. The baby started to cry. His mama came into the room. The baby smiled. Mama saw the bell. She asked the baby where the bell came from. The baby pointed at the window.";
        private void pictureBox_speak_Click(object sender, EventArgs e)
        {
            speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(story);
        }

        private void pictureBox_mute_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Pause();
        }
    }
}
