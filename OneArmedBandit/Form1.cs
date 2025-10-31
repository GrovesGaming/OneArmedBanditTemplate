using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random rangen = new Random();
        // int value for score initialized to 10
        int score = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            // get random values for each reel (store each in separate int variable)
            int reel1 = rangen.Next(1, 3);
            int reel2 = rangen.Next(1, 3);
            int reel3 = rangen.Next(1, 3);


            // check value of reel 1 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (reel1)
            {
                    case 1:
                    pictureBox1.BackgroundImage = Properties.Resources._7_;
                    break;
                    case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.cherry;
                    break;
                    default:
                    pictureBox1.BackgroundImage = Properties.Resources.diamond;
                    break;
            }


            // check value of reel 2 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (reel2)
            {
                    case 1:
                    pictureBox2.BackgroundImage = Properties.Resources._7_;
                    break;
                    case 2:
                    pictureBox2.BackgroundImage = Properties.Resources.cherry;
                    break;
                    default:
                    pictureBox2.BackgroundImage = Properties.Resources.diamond;
                    break;
            }
            // check value of reel 3 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (reel3)
            {
                    case 1:
                    pictureBox3.BackgroundImage = Properties.Resources._7_;
                    break;
                    case 2:
                    pictureBox3.BackgroundImage = Properties.Resources.cherry;
                    break;
                    default:
                    pictureBox3.BackgroundImage = Properties.Resources.diamond;
                    break;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         
            if (reel1 == reel2 && reel2 == reel3)
            {
                // display "winner" message
                MessageBox.Show("You win!");
                // add 3 to score
                score += 3;
            }
            else
            {
                // display "play again" message
                MessageBox.Show("Try again!");
                // subtract 1 from score
                score -= 1;
            }

            // if score has reached 0 display "lose" message and set button enabled property to false
            if (score <= 0)
            {
                // display "lose" message
                MessageBox.Show("You lose!");
                // disable spin button
                spinButton.Enabled = false;
            }

            // display updated score
            outputLabel.Text = "Score: " + score.ToString();

        }
    }
}
