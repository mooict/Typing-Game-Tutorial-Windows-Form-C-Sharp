using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class Form1 : Form
    {

        string[] words = {"internet" , "programming", "mooict", "coding", "sky", "banana", "chair", "marbles", "puzzles"};

        Random rnd = new Random();

        int correct = 0;
        int incorrect = 0;


        public Form1()
        {
            InitializeComponent();


            lblword.Text = words[rnd.Next(0, words.Length) ];
        }

        private void checkGame(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {

                if(textBox1.Text == lblword.Text)
                {
                    correct++;
                    lblword.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }
                else
                {
                    incorrect++;
                    lblword.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }

                lblright.Text = "Correct: " + correct;
                lblwrong.Text = "Incorrect: " + incorrect;

            }


        }
    }
}
