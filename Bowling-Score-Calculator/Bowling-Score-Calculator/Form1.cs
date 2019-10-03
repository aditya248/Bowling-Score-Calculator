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
        bool extraRound = true;// Allows to give 2 or 1 extra throws depending on strike or spare.
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
            extraRound = true;
            isStrike = false;
            strike = new List<Strike>();
            richTextBox1.Text = "";
            scoreLabel.Text = "";
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

        }

        #endregion Game Logic
    }
}
