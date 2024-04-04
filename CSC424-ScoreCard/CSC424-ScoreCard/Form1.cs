using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC424_ScoreCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //TODO Table NO longer subject to change.

        #region Shot made buttons

        #region 2pt make/miss Buttons

        //The label for homescore is lblHomeScore
        private void _2ptMade_Click(object sender, EventArgs e)
        {
            lblHomeScore.Text = (int.Parse(lblHomeScore.Text) + 2).ToString();
            
        }

        private void _2ptMissed_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 3pt make/miss buttons 
        private void _3ptMade_Click(object sender, EventArgs e)
        {
            lblHomeScore.Text = (int.Parse(lblHomeScore.Text) + 3).ToString();
        }

        private void _3ptMissed_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Freethrow make/miss

        private void _FreeThrwMade_Click(object sender, EventArgs e)
        {
            lblHomeScore.Text = (int.Parse(lblHomeScore.Text) + 1).ToString();
        }

        private void _FreeThrwMissed_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion//end make/miss group

        #region REB, BLK, AST, STL, TO Buttons
        private void _Rebound_Click(object sender, EventArgs e)
        {

        }

        private void _Block_Click(object sender, EventArgs e)
        {

        }

        private void _Assist_Click(object sender, EventArgs e)
        {

        }

        private void _Steal_Click(object sender, EventArgs e)
        {

        }

        private void _TurnOver_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region player list

        #region players 1-7
        
        private void _player1_Click(object sender, EventArgs e)
        {
            //Rows can be updated with (Game/SeasonStatTable).RowCount = number; 
            //So rows can be added as you add players.
             
        }

        private void _player2_Click(object sender, EventArgs e)
        {

        }

        private void _player3_Click(object sender, EventArgs e)
        {
            
        }

        private void _player4_Click(object sender, EventArgs e)
        {

        }

        private void _player5_Click(object sender, EventArgs e)
        {

        }

        private void _player6_Click(object sender, EventArgs e)
        {

        }

        private void _player7_Click(object sender, EventArgs e)
        {

        }
        #endregion
    

        #region players 8-15
        private void _player8_Click(object sender, EventArgs e)
        {

        }

        private void _player9_Click(object sender, EventArgs e)
        {

        }

        private void _player10_Click(object sender, EventArgs e)
        {

        }

        private void _player11_Click(object sender, EventArgs e)
        {

        }

        private void _player12_Click(object sender, EventArgs e)
        {

        }

        private void _player13_Click(object sender, EventArgs e)
        {

        }

        private void _player14_Click(object sender, EventArgs e)
        {

        }

        private void _player15_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion//end playerlist 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Opponent Score
        private void _oppnt2ptMade_Click(object sender, EventArgs e)
        {
            //the label for away score is lblAwayScore
            lblAwayScore.Text = (int.Parse(lblAwayScore.Text) + 2).ToString();
        }

        private void _oppnt3ptMade_Click(object sender, EventArgs e)
        {
            lblAwayScore.Text = (int.Parse(lblAwayScore.Text) + 3).ToString();
        }

        private void _oppntFreethrwMade_Click(object sender, EventArgs e)
        {
            lblAwayScore.Text = (int.Parse(lblAwayScore.Text) + 1).ToString();
        }
        #endregion
    }
}
