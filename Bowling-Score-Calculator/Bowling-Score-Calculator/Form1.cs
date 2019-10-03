using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowling_Score_Calculator
{
    public partial class Form1 : Form
    {
        #region Global Variables

        int score = 0; //Keeps track of score.
        int frame = 1; //Keeps track of frame.
        int throws = 20; //No. of throws in a game of bowling.
        bool spare = false; // True if spare.
        int spareCount = 0; // Store the extra point for spare.
        bool extraThrow = true;// Allows to give 2 or 1 extra throws depending on strike or spare.
        bool isStrike = false; // True if strike
        List<Strike> strike = new List<Strike>(); // Stores extra points for strike

        #endregion Global Variables


        public Form1()
        {
            InitializeComponent();
        }
        #region Event Methods
        /// <summary>
        /// Click event handler for bowling score
        /// </summary>
        /// <param name="number">Bowling score</param>
        public void number_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(((Button)sender).Text);
            BowlingScoreCalculator(number);
        }

        /// <summary>
        /// Resets the Game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            score = 0;
            frame = 1;
            throws = 20;
            spareCount = 0;
            spare = false;
            extraThrow = true;
            isStrike = false;
            strike = new List<Strike>();
            richTextBox1.Text = "";
            scoreLabel.Text = "";
            endLabel.Text = "";
            bowlingScoreButtonState(true, 10);

        }
        #endregion Event Methods

        #region Helper Methods
        /// <summary>
        /// Enables/Disables bowling score buttons so user is unable to score more than 10.
        /// </summary>
        /// <param name="enable"> true if enable all</param>
        /// <param name="num">value 10 to enable all and value of 1st throw of the round to disable</param>
        private void bowlingScoreButtonState(bool enable, int num)
        {
            int x = 11 - num;
            for (int i = x; i <= 10; i++)
            {
                Control[] buttons = this.Controls.Find(String.Format("button{0}", i), false);
                Button btn = (buttons[0] as Button);
                btn.Enabled = enable;
            }
        }
        #endregion Helper Methods

        #region Game Logic

        /// <summary>
        /// Calculate the bowling score
        /// </summary>
        /// <param name="number"></param>
        private void BowlingScoreCalculator(int number)
        {
            if (throws != 0) //Check if any throws are left.
            {
                //Check if frame's first throw
                if (throws % 2 == 0)
                {
                    //Frame number, reduce throw, increase score and disable bowling score.
                    richTextBox1.Text += extraThrow ? "\nFrame " + frame + ": " + number : "\nExtra Frame " + ": " + number;
                    throws--;
                    score += number;
                    bowlingScoreButtonState(false, number);

                    //isStrike true if it was strike on previous throw.
                    if (isStrike)
                    {
                        int remove = -1;
                        for (int i = 0; i < strike.Count; i++)
                        {
                            if (strike[i].point1 == -1)
                            {
                                strike[i].point1 = number;
                                score += strike[i].point1;
                                break;
                            }
                            if (strike[i].point2 == -1)
                            {
                                strike[i].point2 = number;
                                score += strike[i].point2;
                                remove = i;
                            }

                        }
                        if (remove > -1)
                        {
                            //Remove the strike after extra points are added.
                            strike.RemoveAt(remove);
                            remove = -1;
                        }
                    }

                    //Checks for spare
                    if (spare)
                    {
                        score += number;
                        spare = false;
                    }
                    spareCount = number;

                    // If strike
                    if (number == 10)
                    {
                        //Cancel next throw , add strike stroage to list, 
                        throws--;
                        richTextBox1.Text += "      Score: " + score;
                        bowlingScoreButtonState(true, 10);
                        isStrike = true;
                        Strike Strike = new Strike();
                        strike.Add(Strike);
                        frame++;
                        // Check if there is strike on last frame
                        if (throws == 0 && extraThrow)
                        {
                            // Get two extra throws.
                            throws = throws + 2;
                            extraThrow = false;
                        }
                    }
                }
                else
                {
                    richTextBox1.Text += extraThrow ? "," + number : "\nExtra Throw: " + number;
                    throws--;
                    frame++;
                    score += number;
                    richTextBox1.Text += "      Score: " + score;
                    bowlingScoreButtonState(true, 10);
                    spareCount += number;

                    //If spare
                    if (spareCount == 10)
                    {
                        spare = true;
                        //Check if there is spare on last frame.
                        if (throws == 0 && extraThrow)
                        {
                            //Get extra throw
                            extraThrow = false;
                            throws = throws + 1;
                        }
                    }

                    if (isStrike)
                    {
                        score += number;
                        strike.RemoveAt(strike.Count - 1);
                        isStrike = false;
                    }

                }
            }
            else
            {
                endLabel.Text = "Game Ended! Click Reset Game to play game.";
            }

            //Update score label
            scoreLabel.Text = score.ToString();
        }

        #endregion Game Logic
    }
}
