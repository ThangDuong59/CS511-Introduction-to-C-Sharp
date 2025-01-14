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
    public partial class FormTA07 : Form
    {
        public FormTA07()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizer;
        string story = "It is December. That means it is Christmas time. Christmas time means Santa Claus is coming. Sara and Billy love Christmas. They love Santa Claus. They love the gifts from Santa. Last year they got nice gifts. Sara got a teddy bear and a rubber duck. Billy got a green boat and a rubber duck. The rubber ducks float. When Sara takes a bath, her pink duck floats in the water. When Billy takes a bath, his blue duck floats in the water. One time Billy put a goldfish into the tub. It swam for a while. Then it died. He buried it in the back yard. He was sad. This year Sara and Billy want bicycles. Sara wants a red bike. Billy wants a blue bike. Mama said she would talk to daddy. Sara asked mama, \"Why don't you talk to Santa?\" Mama said, \"That's a good idea.When daddy comes home, he and I will talk to Santa.\"";
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
