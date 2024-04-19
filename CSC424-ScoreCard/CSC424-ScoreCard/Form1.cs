using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC424_ScoreCard
{

    public partial class Form1 : Form
    {
        int tournmentCounter = 0;

        Dictionary<string, PlayerStats> playerStats = new Dictionary<string, PlayerStats>();
        public Form1()
        {
            InitializeComponent();
            InitializePlayerStats();
        }
        private string selectedPlayerName;

        private void InitializePlayerStats()
        {
            for (int i = 1; i <= 15; i++)
            {
                string playerName = "Player " + i;
                playerStats.Add(playerName, new PlayerStats());
            }
        }

        private void UpdateGameStatTable()
        {
            // Clear existing rows
            GameStatTable.Rows.Clear();

            // Add rows for each player
            foreach (var playerStat in playerStats)
            {
                GameStatTable.Rows.Add(playerStat.Key,
                                      playerStat.Value.Points,
                                      playerStat.Value.Assists,
                                      playerStat.Value.Rebound,
                                      playerStat.Value.Steals,
                                      playerStat.Value.Blocks,
                                      playerStat.Value.Turnovers);
            }
        }
        //TODO Table NO longer subject to change.

        #region Shot made buttons

        #region 2pt make/miss Buttons

        //The label for homescore is lblHomeScore
        private void _2ptMade_Click(object sender, EventArgs e)
        {
            lblHomeScore.Text = (int.Parse(lblHomeScore.Text) + 2).ToString();
            playerStats[selectedPlayerName].Points += 2;
            UpdateGameStatTable();

        }

        private void _2ptMissed_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 3pt make/miss buttons 
        private void _3ptMade_Click(object sender, EventArgs e)
        {
            lblHomeScore.Text = (int.Parse(lblHomeScore.Text) + 3).ToString();
            playerStats[selectedPlayerName].Points += 3;
            UpdateGameStatTable();
        }

        private void _3ptMissed_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Freethrow make/miss

        private void _FreeThrwMade_Click(object sender, EventArgs e)
        {
            lblHomeScore.Text = (int.Parse(lblHomeScore.Text) + 1).ToString();
            playerStats[selectedPlayerName].Points += 1;
            UpdateGameStatTable();
        }

        private void _FreeThrwMissed_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion//end make/miss group

        #region REB, BLK, AST, STL, TO Buttons
        private void _Rebound_Click(object sender, EventArgs e)
        {
            playerStats[selectedPlayerName].Rebound += 1;
            UpdateGameStatTable();
        }

        private void _Block_Click(object sender, EventArgs e)
        {
            playerStats[selectedPlayerName].Blocks += 1;
            UpdateGameStatTable();
        }

        private void _Assist_Click(object sender, EventArgs e)
        {
            playerStats[selectedPlayerName].Assists += 1;
            UpdateGameStatTable();
        }

        private void _Steal_Click(object sender, EventArgs e)
        {
            playerStats[selectedPlayerName].Steals += 1;
            UpdateGameStatTable();
        }

        private void _TurnOver_Click(object sender, EventArgs e)
        {
            playerStats[selectedPlayerName].Turnovers += 1;
            UpdateGameStatTable();
        }
        #endregion


        #region player list

        #region players 1-7
        
        private void _player1_Click(object sender, EventArgs e)
        {
            //Rows can be updated with (Game/SeasonStatTable).RowCount = number; 
            //So rows can be added as you add players.
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 1";

            UpdateGameStatTable();
        }

        private void _player2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 2";

            UpdateGameStatTable();
        }

        private void _player3_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 3";

            UpdateGameStatTable();
        }

        private void _player4_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 4";

            UpdateGameStatTable();
        }

        private void _player5_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 5";

            UpdateGameStatTable();
        }

        private void _player6_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 6";

            UpdateGameStatTable();

        }

        private void _player7_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 7";

            UpdateGameStatTable();

        }
        #endregion
    

        #region players 8-15
        private void _player8_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 8";

            UpdateGameStatTable();
        }

        private void _player9_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 9";

            UpdateGameStatTable();
        }

        private void _player10_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 10";

            UpdateGameStatTable();
        }

        private void _player11_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 11";

            UpdateGameStatTable();
        }

        private void _player12_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 12";

            UpdateGameStatTable();
        }

        private void _player13_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 13";

            UpdateGameStatTable();
        }

        private void _player14_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 14";

            UpdateGameStatTable();
        }

        private void _player15_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 15";

            UpdateGameStatTable();
        }

        #endregion

        #endregion//end playerlist 

        private void changeText()
        {
            #region LeftSideButtons

            if (team1.Visible == false)
            {
                team1.Text = tournamentInput.Text;
                team1.Visible = true;
            }
            else if (team2.Visible == false)
            {
                team2.Text = tournamentInput.Text;
                team2.Visible = true;
                qFinal1.Visible = true;
            }
            else if (team3.Visible == false)
            {
                team3.Text = tournamentInput.Text;
                team3.Visible = true;
                qFinal2.Visible = true;
                sFinal1.Visible = true;
            }
            else if (team4.Visible == false)
            {
                team4.Text = tournamentInput.Text;
                team4.Visible = true;
            }
            else if (team5.Visible == false)
            {
                team5.Text = tournamentInput.Text;
                team5.Visible = true;
                qFinal3.Visible = true;
                sFinal2.Visible = true;
                final1.Visible = true;
            }
            else if (team6.Visible == false)
            {
                team6.Text = tournamentInput.Text;
                team6.Visible = true;
            }
            else if (team7.Visible == false)
            {
                team7.Text = tournamentInput.Text;
                team7.Visible = true;
                qFinal4.Visible = true;
            }
            else if (team8.Visible == false)
            {
                team8.Text = tournamentInput.Text;
                team8.Visible = true;
            }
            #endregion

            #region RightSideButtons

            else if (team9.Visible == false)
            {
                team9.Text = tournamentInput.Text;
                team9.Visible = true;
                qFinal5.Visible = true;
                sFinal3.Visible = true;
                final2.Visible = true;
            }
            else if (team10.Visible == false)
            {
                team10.Text = tournamentInput.Text;
                team10.Visible = true;
            }
            else if (team11.Visible == false)
            {
                team11.Text = tournamentInput.Text;
                team11.Visible = true;
                qFinal6.Visible = true;
            }
            else if (team12.Visible == false)
            {
                team12.Text = tournamentInput.Text;
                team12.Visible = true;
            }
            else if (team13.Visible == false)
            {
                team13.Text = tournamentInput.Text;
                team13.Visible = true;
                qFinal7.Visible = true;
                sFinal4.Visible = true;
            }
            else if (team14.Visible == false)
            {
                team14.Text = tournamentInput.Text;
                team14.Visible = true;
            }
            else if (team15.Visible == false)
            {
                team15.Text = tournamentInput.Text;
                team15.Visible = true;
                qFinal8.Visible = true;
            }
            else if (team16.Visible == false)
            {
                team16.Text = tournamentInput.Text;
                team16.Visible = true;
                tournamentInput.Visible = false;
            }
            #endregion

            tournamentInput.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tournamentInput.KeyPress += (sndr, ev) =>
            {
                if (ev.KeyChar.Equals((char)13))
                {
                    changeText();
                    ev.Handled = true; // suppress default handling
                }
            };
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

        public class PlayerStats
        {
            public int Rebound { get; set; }
            public int Assists { get; set; }
            public int Turnovers { get; set; }
            public int Steals { get; set; }
            public int Points { get; set; }
            public int Blocks { get; set; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        #region Bracket Buttons
        private void team1_Click(object sender, EventArgs e)
        {
            team2.Enabled = false;
            team2.BackColor = Color.Red;

            team1.Enabled = false;
            team1.BackColor = Color.Green;

            qFinal1.Text = team1.Text;
        }

        private void team2_Click(object sender, EventArgs e)
        {
            team1.Enabled = false;
            team1.BackColor = Color.Green;

            team2.Enabled = false;
            team2.BackColor = Color.Red;

            qFinal1.Text = team2.Text;
        }

        private void team3_Click(object sender, EventArgs e)
        {
            team3.Enabled = false;
            team3.BackColor = Color.Green;

            team4.Enabled = false;
            team4.BackColor = Color.Red;

            qFinal2.Text = team3.Text;
        }

        private void team4_Click(object sender, EventArgs e)
        {
            team4.Enabled = false;
            team4.BackColor = Color.Green;

            team3.Enabled = false;
            team3.BackColor = Color.Red;

            qFinal2.Text = team4.Text;
        }

        private void team5_Click(object sender, EventArgs e)
        {
            team5.Enabled = false;
            team5.BackColor = Color.Green;

            team6.Enabled = false;
            team6.BackColor = Color.Red;

            qFinal3.Text = team5.Text;
        }

        private void team6_Click(object sender, EventArgs e)
        {
            team6.Enabled = false;
            team6.BackColor = Color.Green;

            team5.Enabled = false;
            team5.BackColor = Color.Red;

            qFinal3.Text = team6.Text;
        }

        private void team7_Click(object sender, EventArgs e)
        {
            team7.Enabled = false;
            team7.BackColor = Color.Green;

            team8.Enabled = false;
            team8.BackColor = Color.Red;

            qFinal4.Text = team7.Text;
        }

        private void team8_Click(object sender, EventArgs e)
        {
            team8.Enabled = false;
            team8.BackColor = Color.Green;

            team7.Enabled = false;
            team7.BackColor = Color.Red;

            qFinal4.Text = team8.Text;
        }

        private void team9_Click(object sender, EventArgs e)
        {
            team9.Enabled = false;
            team9.BackColor = Color.Green;

            team10.Enabled = false;
            team10.BackColor = Color.Red;

            qFinal5.Text = team9.Text;
        }

        private void team10_Click(object sender, EventArgs e)
        {
            team10.Enabled = false;
            team10.BackColor = Color.Green;

            team9.Enabled = false;
            team9.BackColor = Color.Red;

            qFinal5.Text = team10.Text;
        }

        private void team5_Click_1(object sender, EventArgs e)
        {
            team5.Enabled = false;
            team5.BackColor = Color.Green;

            team6.Enabled = false;
            team6.BackColor = Color.Red;

            qFinal3.Text = team5.Text;
        }


        private void team11_Click(object sender, EventArgs e)
        {
            team11.Enabled = false;
            team11.BackColor = Color.Green;

            team12.Enabled = false;
            team12.BackColor = Color.Red;

            qFinal6.Text = team11.Text;
        }

        private void team12_Click(object sender, EventArgs e)
        {
            team12.Enabled = false;
            team12.BackColor = Color.Green;

            team11.Enabled = false;
            team11.BackColor = Color.Red;

            qFinal6.Text = team12.Text;
        }

        private void team13_Click(object sender, EventArgs e)
        {
            team13.Enabled = false;
            team13.BackColor = Color.Green;

            team14.Enabled = false;
            team14.BackColor = Color.Red;

            qFinal7.Text = team13.Text;
        }

        private void team14_Click(object sender, EventArgs e)
        {
            team14.Enabled = false;
            team14.BackColor = Color.Green;

            team13.Enabled = false;
            team13.BackColor = Color.Red;

            qFinal7.Text = team14.Text;
        }

        private void team15_Click(object sender, EventArgs e)
        {
            team15.Enabled = false;
            team15.BackColor = Color.Green;

            team16.Enabled = false;
            team16.BackColor = Color.Red;

            qFinal8.Text = team15.Text;
        }

        private void team16_Click(object sender, EventArgs e)
        {
            team16.Enabled = false;
            team16.BackColor = Color.Green;

            team15.Enabled = false;
            team15.BackColor = Color.Red;

            qFinal8.Text = team16.Text;
        }

        private void qFinal1_Click(object sender, EventArgs e)
        {
            qFinal1.Enabled = false;
            qFinal1.BackColor = Color.Green;

            qFinal2.Enabled = false;
            qFinal2.BackColor = Color.Red;

            sFinal1.Text = qFinal1.Text;
        }

        private void qFinal2_Click(object sender, EventArgs e)
        {
            qFinal2.Enabled = false;
            qFinal2.BackColor = Color.Green;

            qFinal1.Enabled = false;
            qFinal2.BackColor = Color.Red;

            sFinal1.Text = qFinal2.Text;
        }

        private void qFinal3_Click(object sender, EventArgs e)
        {
            qFinal3.Enabled = false;
            qFinal3.BackColor = Color.Green;

            qFinal4.Enabled = false;
            qFinal4.BackColor = Color.Red;

            sFinal2.Text = qFinal3.Text;
        }

        private void qFinal4_Click(object sender, EventArgs e)
        {
            qFinal4.Enabled = false;
            qFinal4.BackColor = Color.Green;

            qFinal3.Enabled = false;
            qFinal3.BackColor = Color.Red;

            sFinal2.Text = qFinal4.Text;
        }

        private void qFinal5_Click(object sender, EventArgs e)
        {
            qFinal5.Enabled = false;
            qFinal5.BackColor = Color.Green;

            qFinal6.Enabled = false;
            qFinal6.BackColor = Color.Red;

            sFinal3.Text = qFinal5.Text;
        }

        private void qFinal6_Click(object sender, EventArgs e)
        {
            qFinal6.Enabled = false;
            qFinal6.BackColor = Color.Green;

            qFinal5.Enabled = false;
            qFinal5.BackColor = Color.Red;

            sFinal3.Text = qFinal6.Text;
        }

        private void qFinal7_Click(object sender, EventArgs e)
        {
            qFinal7.Enabled = false;
            qFinal7.BackColor = Color.Green;

            qFinal8.Enabled = false;
            qFinal8.BackColor = Color.Red;

            sFinal4.Text = qFinal7.Text;
        }

        private void qFinal8_Click(object sender, EventArgs e)
        {
            qFinal8.Enabled = false;
            qFinal8.BackColor = Color.Green;

            qFinal7.Enabled = false;
            qFinal7.BackColor = Color.Red;

            sFinal4.Text = qFinal8.Text;
        }

        private void sFinal1_Click(object sender, EventArgs e)
        {
            sFinal1.Enabled = false;
            sFinal1.BackColor = Color.Green;

            sFinal2.Enabled = false;
            sFinal2.BackColor = Color.Red;

            final1.Text = sFinal1.Text;
        }

        private void sFinal2_Click(object sender, EventArgs e)
        {
            sFinal2.Enabled = false;
            sFinal2.BackColor = Color.Green;

            sFinal1.Enabled = false;
            sFinal1.BackColor = Color.Red;

            final1.Text = sFinal2.Text;
        }

        private void sFinal3_Click(object sender, EventArgs e)
        {
            sFinal3.Enabled = false;
            sFinal3.BackColor = Color.Green;

            sFinal4.Enabled = false;
            sFinal4.BackColor = Color.Red;

            final2.Text = sFinal3.Text;
        }

        private void sFinal4_Click(object sender, EventArgs e)
        {
            sFinal4.Enabled = false;
            sFinal4.BackColor = Color.Green;

            sFinal3.Enabled = false;
            sFinal3.BackColor = Color.Red;

            final2.Text = sFinal4.Text;
        }

        private void final1_Click(object sender, EventArgs e)
        {
            final1.Enabled = false;
            final1.BackColor = Color.Green;

            final2.Enabled = false;
            final2.BackColor = Color.Red;

            winnerLabel.Text = final1.Text;
        }

        private void final2_Click(object sender, EventArgs e)
        {
            final2.Enabled = false;
            final2.BackColor = Color.Green;

            final1.Enabled = false;
            final1.BackColor = Color.Red;

            winnerLabel.Text = final2.Text;
            winnerLabel.Visible = true;
        }

        private void winnerLabel_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void gameComplete_Click(object sender, EventArgs e)
        {
            
                
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
