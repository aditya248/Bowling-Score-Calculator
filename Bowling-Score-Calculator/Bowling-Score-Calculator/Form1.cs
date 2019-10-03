﻿using System;
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

        /// <summary>
        /// Click event handler for bowling score
        /// </summary>
        /// <param name="number">Bowling score</param>
        public void number_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(((Button)sender).Text);

        }
    }
}
