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
    public partial class FormTA05 : Form
    {
        public FormTA05()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizer;
        string story = "The tree was full of red apples. The farmer was riding his brown horse. He stopped under the tree. He reached out and picked an apple off a branch. He bit into the raw apple. He enjoyed the apple. His horse turned its head to look at him. The farmer picked another apple off the tree. He gave it to the horse. The horse ate the raw apple. The horse enjoyed the apple. The farmer put a dozen apples into a bag. He rode the horse back home. He put the horse in the barn. He walked into his house. The cat rubbed up against his leg. He gave the cat a bowl of warm milk. He sat down on the sofa. He opened a book to read. His wife came home. She cooked the raw apples. She made an apple pie. They ate bread and hot soup for dinner. They enjoyed the bread and soup. They had hot apple pie for dessert. They both enjoyed the apple pie.";
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
