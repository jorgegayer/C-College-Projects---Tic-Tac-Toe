//Name: Assignment 1
//Program: Software Development Diploma
//Course Code: SODV2101 - Rapid Application Development
//Author: Jorge Eduardo Schmitt Gayer
//Student IDs: 424267



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {

        Game myGame;

        private void disablePlayers()
        {
            //Game is over. Disable all movements and let the user restart the game
            clearCells();
            grpPlayer1.Enabled = false;
            grpPlayer2.Enabled = false;
            grpBoard.Enabled = false;
        }

        private void clearCells()
        {
            // clear the board
            lblCell11.Text = "";
            lblCell11.BorderStyle = BorderStyle.FixedSingle;

            lblCell12.Text = "";
            lblCell12.BorderStyle = BorderStyle.FixedSingle;

            lblCell13.Text = "";
            lblCell13.BorderStyle = BorderStyle.FixedSingle;

            lblCell21.Text = "";
            lblCell21.BorderStyle = BorderStyle.FixedSingle;

            lblCell22.Text = "";
            lblCell22.BorderStyle = BorderStyle.FixedSingle;

            lblCell23.Text = "";
            lblCell23.BorderStyle = BorderStyle.FixedSingle;

            lblCell31.Text = "";
            lblCell31.BorderStyle = BorderStyle.FixedSingle;

            lblCell32.Text = "";
            lblCell32.BorderStyle = BorderStyle.FixedSingle;

            lblCell33.Text = "";
            lblCell33.BorderStyle = BorderStyle.FixedSingle;



        }

        private void enablePlayer1()
        {
            // set the turn for player one
            grpPlayer1.BackColor = Color.AliceBlue;
            grpPlayer2.BackColor = Color.Transparent;
            lblDisplay1.Visible = true;
            lblDisplay2.Visible = false;

        }

        private void enablePlayer2()
        {
            // set the turn for player two
            grpPlayer2.BackColor = Color.AliceBlue;
            grpPlayer1.BackColor = Color.Transparent;
            lblDisplay1.Visible = false;
            lblDisplay2.Visible = true;
        }


        private void nextPlayer(Label lbl)
        {
            //check who is the next player and changes the screen accordingly
            if (myGame.currentPlayer().Symbol == "X")
            {
                enablePlayer1();
            }
            else
            {
                enablePlayer2();
            }


        }
        private void clickCell(Label lbl)
        {
            //user can only play when the text is empty, meaning the cell was not selected yet
            if (lbl.Text == "") { 

                //check who is the current player and set to player
                Player player = myGame.currentPlayer();

                //Play passing the position received on the label tag
                myGame.Play(lbl.Tag.ToString());

                // set the player symbol to the text
                lbl.Text = player.Symbol;

                //set the player color to the label
                lbl.ForeColor = player.Argb;

                //set the label to "Clicked"
                lbl.BorderStyle = BorderStyle.Fixed3D;

                // check if the movement generated a winner
                if (player.Winner)
                {
                    MessageBox.Show(player.Symbol + " Is the Winner!");
                    disablePlayers();
                }
                else
                    // check if it was a draw
                    if (myGame.checkDraw())
                {
                    MessageBox.Show("This is a Draw!! There are no Winners here!!");
                    disablePlayers();
                }
                else
                    //set the screen for the next player
                    nextPlayer(lbl);
            }
        }
        private void startGame()
        {
            //starting a new game
            this.myGame = new Game(lblSymbol1.Text, lblSymbol2.Text);

            //in the future the symbol can be chosed by the user
            myGame.player1.Symbol = lblSymbol1.Text;
            myGame.player2.Symbol = lblSymbol2.Text;

            // enable the player group box
            grpPlayer1.Enabled = true;
            grpPlayer2.Enabled = true;

            //enable the board
            grpBoard.Enabled = true;

            //restart the game
            myGame.Restart();

            // set the turn for the player one (default)
            enablePlayer1();
        }
        public TicTacToe()
        {
            InitializeComponent();
            //start the game with the players disabled. 
            //User needs to click on the button to start
            disablePlayers();
        }


        private void programExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

       


        private void btnStart_Click(object sender, EventArgs e)
        {
            //clear cells and start the game
            clearCells();
            startGame();
        }


        private void SendtoCell(object sender, EventArgs e)
        {
            // when player click on the label, it calls a function passing the clicked label as parameter
            Label lbl =  (Label)sender;
            clickCell(lbl);
        }
    }
}
